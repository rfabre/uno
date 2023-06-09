﻿#nullable enable

using System;
using Uno.Foundation;
using Uno.UI.Xaml.Core;
using Uno.UI.Xaml.Input;
using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;
using Microsoft.UI.Xaml.Input;

#if NET7_0_OR_GREATER
using System.Runtime.InteropServices.JavaScript;
#endif

namespace Uno.UI.Xaml.Controls;

internal partial class SystemFocusVisual : Control
{
	partial void AttachVisualPartial()
	{
		if (FocusedElement == null)
		{
			return;
		}

#if NET7_0_OR_GREATER
		NativeMethods.AttachVisual(HtmlId, FocusedElement.HtmlId);
#else
		WebAssemblyRuntime.InvokeJS($"Microsoft.UI.Xaml.Input.FocusVisual.attachVisual({HtmlId}, {FocusedElement.HtmlId})");
#endif
	}

	partial void DetachVisualPartial()
	{
#if NET7_0_OR_GREATER
		NativeMethods.DetachVisual();
#else
		WebAssemblyRuntime.InvokeJS($"Microsoft.UI.Xaml.Input.FocusVisual.detachVisual()");
#endif
	}

#if NET7_0_OR_GREATER
	[JSExport]
#endif
	public static int DispatchNativePositionChange(int focusVisualId)
	{
		var element = UIElement.GetElementFromHandle(focusVisualId) as SystemFocusVisual;
		element?.SetLayoutProperties();

		return 0;
	}

#if NET7_0_OR_GREATER
	internal static partial class NativeMethods
	{
		[JSImport("globalThis.Microsoft.UI.Xaml.Input.FocusVisual.attachVisual")]
		internal static partial void AttachVisual(IntPtr htmlId, IntPtr focusedElementId);

		[JSImport("globalThis.Microsoft.UI.Xaml.Input.FocusVisual.detachVisual")]
		internal static partial void DetachVisual();
	}
#endif
}
