﻿using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Diagnostics;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using Microsoft.CodeAnalysis;
using Uno.Extensions;
using Uno.UWPSyncGenerator.AttributeGeneration;

namespace Uno.UWPSyncGenerator
{
	class SyncGenerator : Generator
	{
		protected override void ProcessType(INamedTypeSymbol type, INamespaceSymbol ns)
		{
			var folder = $@"{GetNamespaceBasePath(type)}\{ns}";
			var info = Directory.CreateDirectory(folder);

			// Console.WriteLine(type.ToString());

			// if (type.Name == "BrushCollection" || type.Name == "StringMap")
			// if (type.Name == "StatusBar")
			{
				using (var typeWriter = new StreamWriter(Path.Combine(folder, type.Name) + ".cs"))
				{
					var b = new IndentedStringBuilder();

					b.AppendLineInvariant($"#pragma warning disable 108 // new keyword hiding");
					b.AppendLineInvariant($"#pragma warning disable 114 // new keyword hiding");
					using (b.BlockInvariant($"namespace {ns}"))
					{
						WriteType(type, b);
					}

					typeWriter.Write(b.ToString());
				}
			}
		}

		private static string KindToKeyword(TypeKind kind)
		{
			return kind switch
			{
				TypeKind.Class => "class",
				TypeKind.Struct => "struct",
				TypeKind.Delegate => "delegate",
				TypeKind.Enum => "enum",
				TypeKind.Interface => "interface",
				_ => throw new ArgumentOutOfRangeException($"Unexpected TypeKind '{kind}'."),
			};
		}

		private static ImmutableArray<IAttributeDescription> s_attributeDescriptions = ImmutableArray.Create<IAttributeDescription>(
			new AttributeUsageAttributeDescription(),
			new BindableAttributeDescription(),
			new ContentPropertyAttributeDescription(),
			new DeprecatedAttributeDescription(),
			new FlagsAttributeDescription()
			);

		private void WriteType(INamedTypeSymbol type, IndentedStringBuilder b)
		{
			var kind = type.TypeKind;
			var partialModifier = type.TypeKind != TypeKind.Enum ? "partial" : "";
			var allSymbols = GetAllSymbols(type);

			var staticQualifier = type.IsStatic ? "static" : "";

			if (SkippedType(type))
			{
				b.AppendLineInvariant($"// Skipped type, see SkippedType method");
				return;
			}

			var writtenMethods = new List<IMethodSymbol>();

			var uwpAttributes = type.GetAttributes().Where(a => !IsIgnoredAttribute(a));
			var attributesToGenerate = new HashSet<string>();

			AddAttributesToGenerate(GetMissingAttributes(uwpAttributes, allSymbols.AndroidSymbol), attributesToGenerate);
			AddAttributesToGenerate(GetMissingAttributes(uwpAttributes, allSymbols.IOSSymbol), attributesToGenerate);
			AddAttributesToGenerate(GetMissingAttributes(uwpAttributes, allSymbols.MacOSSymbol), attributesToGenerate);
			AddAttributesToGenerate(GetMissingAttributes(uwpAttributes, allSymbols.SkiaSymbol), attributesToGenerate);
			AddAttributesToGenerate(GetMissingAttributes(uwpAttributes, allSymbols.WasmSymbol), attributesToGenerate);
			AddAttributesToGenerate(GetMissingAttributes(uwpAttributes, allSymbols.UnitTestsymbol), attributesToGenerate);
			AddAttributesToGenerate(GetMissingAttributes(uwpAttributes, allSymbols.NetStdReferenceSymbol), attributesToGenerate);

			static void AddAttributesToGenerate(IEnumerable<AttributeData> missingAttributes, HashSet<string> attributesToGenerate)
			{
				foreach (var missingAttribute in missingAttributes)
				{
					bool isHandled = false;
					foreach (var attributeDescription in s_attributeDescriptions)
					{
						if (attributeDescription.TryGenerateCodeFromAttributeData(missingAttribute) is { } generatedCode)
						{
							attributesToGenerate.Add(generatedCode);
							isHandled = true;
							break;
						}
					}

					if (!isHandled)
					{
						throw new InvalidOperationException($"Attribute {missingAttribute} could not be handled.");
					}
				}
			}

			foreach (var attributeToGenerate in attributesToGenerate)
			{
				b.AppendLineInvariant("{0}", attributeToGenerate);
			}

			if (type.TypeKind == TypeKind.Delegate)
			{
				BuildDelegate(type, b, allSymbols);
			}
			else
			{
				if (type.Name == "DependencyObject")
				{
					kind = TypeKind.Interface;
				}

				if (type.TypeKind == TypeKind.Enum)
				{
					allSymbols.AppendIf(b);
				}
				else
				{
					allSymbols.AppendIf(b);

					var notImplementedList = allSymbols.GenerateNotImplementedList();

					// We're at a point where the generated code wasn't correct here, and the straightforward
					// fix (to use GenerateNotImplementedList) causes a very large diff. So we special case
					// the addition of the attribute without specific platforms in cases where it doesn't actually matter.
					if (string.IsNullOrEmpty(notImplementedList) || allSymbols.IsNotImplementedInAllPlatforms())
					{
						b.AppendLineInvariant($"[global::Uno.NotImplemented]");
					}
					else
					{
						b.AppendLineInvariant($"[global::Uno.NotImplemented({allSymbols.GenerateNotImplementedList()})]");
					}

					using (b.Indent(-b.CurrentLevel))
					{
						b.AppendLineInvariant("#endif");
					}
				}

				var enumBaseType =
					type.TypeKind == TypeKind.Enum &&
					type.EnumUnderlyingType.SpecialType != SpecialType.System_Int32 ?
						$": {type.EnumUnderlyingType.ToDisplayString()}" :
							string.Empty;

				using (b.BlockInvariant($"public {staticQualifier} {partialModifier} {KindToKeyword(kind)} {type.ToDisplayString(SymbolDisplayFormat.MinimallyQualifiedFormat)} {enumBaseType}{BuildInterfaces(type)}"))
				{
					if (type.TypeKind != TypeKind.Enum)
					{
						BuildProperties(type, b, allSymbols);
						BuildMethods(type, b, allSymbols, writtenMethods);
						BuildEvents(type, b, allSymbols);
					}

					BuildFields(type, b, allSymbols);

					if (type.TypeKind != TypeKind.Enum)
					{
						BuildInterfaceImplementations(type, b, allSymbols, writtenMethods);
					}
				}

				if (type.TypeKind == TypeKind.Enum)
				{
					using (b.Indent(-b.CurrentLevel))
					{
						b.AppendLineInvariant("#endif");
					}
				}
			}
		}

		private static IEnumerable<AttributeData> GetMissingAttributes(IEnumerable<AttributeData> expected, INamedTypeSymbol type)
		{
			if (type is null)
			{
				return expected;
			}

			return expected.ExceptBy(type.GetAttributes(), a => a, AttributeDataClassComparer.Instance);
		}

		private static bool IsIgnoredAttribute(AttributeData attributeData)
		{
			return attributeData.AttributeClass.ToString() is
				"Windows.Foundation.Metadata.GuidAttribute" or
				"Windows.Foundation.Metadata.StaticAttribute" or
				"Windows.Foundation.Metadata.AllowMultipleAttribute" or
				"Windows.Foundation.Metadata.AttributeNameAttribute" or
				"Windows.Foundation.Metadata.MuseAttribute" or
				"Windows.Foundation.Metadata.GCPressureAttribute" or
				"Windows.Foundation.Metadata.ComposableAttribute" or
				"Windows.Foundation.Metadata.ContractVersionAttribute" or
				"Windows.Foundation.Metadata.HasVariantAttribute" or
				"Windows.Foundation.Metadata.DualApiPartitionAttribute" or
				"Windows.Foundation.Metadata.ActivatableAttribute" or
				"Windows.Foundation.Metadata.MarshalingBehaviorAttribute" or
				"Windows.Foundation.Metadata.ThreadingAttribute" or
				"Windows.Foundation.Metadata.ApiContractAttribute" or
				"Windows.Foundation.Metadata.PreviousContractVersionAttribute" or
				"Windows.Foundation.Metadata.VersionAttribute" or
				"Windows.Foundation.Metadata.WebHostHiddenAttribute" or
				"Microsoft.UI.Xaml.CustomAttributes.MUXPropertyChangedCallbackAttribute" or
				"Microsoft.UI.Xaml.CustomAttributes.MUXPropertyChangedCallbackMethodNameAttribute" or
				"Microsoft.UI.Xaml.CustomAttributes.MUXPropertyNeedsDependencyPropertyFieldAttribute" or
				"Microsoft.UI.Xaml.CustomAttributes.MUXHasCustomActivationFactoryAttribute" or
				"Microsoft.UI.Xaml.Controls.InputPropertyAttribute";
		}
	}
}
