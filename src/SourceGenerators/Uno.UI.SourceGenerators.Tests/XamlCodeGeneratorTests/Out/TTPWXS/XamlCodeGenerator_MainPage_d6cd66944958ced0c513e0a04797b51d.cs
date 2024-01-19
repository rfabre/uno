﻿// <autogenerated />
#pragma warning disable CS0114
#pragma warning disable CS0108
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using Uno.UI;
using Uno.UI.Xaml;
using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;
using Microsoft.UI.Xaml.Controls.Primitives;
using Microsoft.UI.Xaml.Data;
using Microsoft.UI.Xaml.Documents;
using Microsoft.UI.Xaml.Media;
using Microsoft.UI.Xaml.Media.Animation;
using Microsoft.UI.Xaml.Shapes;
using Windows.UI.Text;
using Uno.Extensions;
using Uno;
using Uno.UI.Helpers;
using Uno.UI.Helpers.Xaml;
using MyProject;

#if __ANDROID__
using _View = Android.Views.View;
#elif __IOS__
using _View = UIKit.UIView;
#elif __MACOS__
using _View = AppKit.NSView;
#else
using _View = Microsoft.UI.Xaml.UIElement;
#endif

namespace TestRepro
{
	partial class MainPage : global::Microsoft.UI.Xaml.Controls.Page
	{
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		private const string __baseUri_prefix_MainPage_d6cd66944958ced0c513e0a04797b51d = "ms-appx:///TestProject/";
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		private const string __baseUri_MainPage_d6cd66944958ced0c513e0a04797b51d = "ms-appx:///TestProject/";
		private global::Microsoft.UI.Xaml.NameScope __nameScope = new global::Microsoft.UI.Xaml.NameScope();
		private void InitializeComponent()
		{
			NameScope.SetNameScope(this, __nameScope);
			var __that = this;
			base.IsParsing = true;
			// Source 0\MainPage.xaml (Line 1:2)
			base.Content = 
			new global::TestRepro.MyButton
			{
				IsParsing = true,
				MyProperty = typeof(string),
				// Source 0\MainPage.xaml (Line 9:3)
			}
			.MainPage_d6cd66944958ced0c513e0a04797b51d_XamlApply((MainPage_d6cd66944958ced0c513e0a04797b51dXamlApplyExtensions.XamlApplyHandler0)(c0 => 
			{
				global::Uno.UI.FrameworkElementHelper.SetBaseUri(c0, __baseUri_MainPage_d6cd66944958ced0c513e0a04797b51d);
				c0.CreationComplete();
			}
			))
			;
			
			this
			.GenericApply(((c1) => 
			{
				// Source 0\MainPage.xaml (Line 1:2)
				
				// WARNING Property c1.base does not exist on {http://schemas.microsoft.com/winfx/2006/xaml/presentation}Page, the namespace is http://www.w3.org/XML/1998/namespace. This error was considered irrelevant by the XamlFileGenerator
			}
			))
			.GenericApply(((c2) => 
			{
				// Class TestRepro.MainPage
				global::Uno.UI.FrameworkElementHelper.SetBaseUri(c2, __baseUri_MainPage_d6cd66944958ced0c513e0a04797b51d);
				c2.CreationComplete();
			}
			))
			;
			OnInitializeCompleted();

		}
		partial void OnInitializeCompleted();
	}
}
namespace MyProject
{
	static class MainPage_d6cd66944958ced0c513e0a04797b51dXamlApplyExtensions
	{
		public delegate void XamlApplyHandler0(global::TestRepro.MyButton instance);
		[System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
		public static global::TestRepro.MyButton MainPage_d6cd66944958ced0c513e0a04797b51d_XamlApply(this global::TestRepro.MyButton instance, XamlApplyHandler0 handler)
		{
			handler(instance);
			return instance;
		}
	}
}