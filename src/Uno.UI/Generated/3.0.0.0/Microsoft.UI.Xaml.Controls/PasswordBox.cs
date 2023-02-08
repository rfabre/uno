#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Microsoft.UI.Xaml.Controls
{
	#if false || false || false || false || false || false || false
	[global::Uno.NotImplemented]
	#endif
	public  partial class PasswordBox 
	{
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "NET461", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  global::Microsoft.UI.Xaml.TextReadingOrder TextReadingOrder
		{
			get
			{
				return (global::Microsoft.UI.Xaml.TextReadingOrder)this.GetValue(TextReadingOrderProperty);
			}
			set
			{
				this.SetValue(TextReadingOrderProperty, value);
			}
		}
		#endif
		// Skipping already declared property SelectionHighlightColor
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "NET461", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  global::Microsoft.UI.Xaml.Controls.Primitives.FlyoutBase SelectionFlyout
		{
			get
			{
				return (global::Microsoft.UI.Xaml.Controls.Primitives.FlyoutBase)this.GetValue(SelectionFlyoutProperty);
			}
			set
			{
				this.SetValue(SelectionFlyoutProperty, value);
			}
		}
		#endif
		#if false || __IOS__ || NET461 || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__IOS__", "NET461", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  bool PreventKeyboardDisplayOnProgrammaticFocus
		{
			get
			{
				return (bool)this.GetValue(PreventKeyboardDisplayOnProgrammaticFocusProperty);
			}
			set
			{
				this.SetValue(PreventKeyboardDisplayOnProgrammaticFocusProperty, value);
			}
		}
		#endif
		// Skipping already declared property PlaceholderText
		// Skipping already declared property PasswordRevealMode
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "NET461", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  string PasswordChar
		{
			get
			{
				return (string)this.GetValue(PasswordCharProperty);
			}
			set
			{
				this.SetValue(PasswordCharProperty, value);
			}
		}
		#endif
		// Skipping already declared property Password
		// Skipping already declared property MaxLength
		// Skipping already declared property IsPasswordRevealButtonEnabled
		// Skipping already declared property InputScope
		// Skipping already declared property HeaderTemplate
		// Skipping already declared property Header
		// Skipping already declared property Description
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "NET461", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  bool CanPasteClipboardContent
		{
			get
			{
				return (bool)this.GetValue(CanPasteClipboardContentProperty);
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "NET461", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public static global::Microsoft.UI.Xaml.DependencyProperty CanPasteClipboardContentProperty { get; } = 
		Microsoft.UI.Xaml.DependencyProperty.Register(
			nameof(CanPasteClipboardContent), typeof(bool), 
			typeof(global::Microsoft.UI.Xaml.Controls.PasswordBox), 
			new FrameworkPropertyMetadata(default(bool)));
		#endif
		// Skipping already declared property DescriptionProperty
		// Skipping already declared property HeaderProperty
		// Skipping already declared property HeaderTemplateProperty
		// Skipping already declared property InputScopeProperty
		// Skipping already declared property IsPasswordRevealButtonEnabledProperty
		// Skipping already declared property MaxLengthProperty
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "NET461", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public static global::Microsoft.UI.Xaml.DependencyProperty PasswordCharProperty { get; } = 
		Microsoft.UI.Xaml.DependencyProperty.Register(
			nameof(PasswordChar), typeof(string), 
			typeof(global::Microsoft.UI.Xaml.Controls.PasswordBox), 
			new FrameworkPropertyMetadata(default(string)));
		#endif
		// Skipping already declared property PasswordProperty
		// Skipping already declared property PasswordRevealModeProperty
		// Skipping already declared property PlaceholderTextProperty
		#if false || __IOS__ || NET461 || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__IOS__", "NET461", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public static global::Microsoft.UI.Xaml.DependencyProperty PreventKeyboardDisplayOnProgrammaticFocusProperty { get; } = 
		Microsoft.UI.Xaml.DependencyProperty.Register(
			nameof(PreventKeyboardDisplayOnProgrammaticFocus), typeof(bool), 
			typeof(global::Microsoft.UI.Xaml.Controls.PasswordBox), 
			new FrameworkPropertyMetadata(default(bool)));
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "NET461", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public static global::Microsoft.UI.Xaml.DependencyProperty SelectionFlyoutProperty { get; } = 
		Microsoft.UI.Xaml.DependencyProperty.Register(
			nameof(SelectionFlyout), typeof(global::Microsoft.UI.Xaml.Controls.Primitives.FlyoutBase), 
			typeof(global::Microsoft.UI.Xaml.Controls.PasswordBox), 
			new FrameworkPropertyMetadata(default(global::Microsoft.UI.Xaml.Controls.Primitives.FlyoutBase)));
		#endif
		// Skipping already declared property SelectionHighlightColorProperty
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "NET461", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public static global::Microsoft.UI.Xaml.DependencyProperty TextReadingOrderProperty { get; } = 
		Microsoft.UI.Xaml.DependencyProperty.Register(
			nameof(TextReadingOrder), typeof(global::Microsoft.UI.Xaml.TextReadingOrder), 
			typeof(global::Microsoft.UI.Xaml.Controls.PasswordBox), 
			new FrameworkPropertyMetadata(default(global::Microsoft.UI.Xaml.TextReadingOrder)));
		#endif
		// Skipping already declared method Microsoft.UI.Xaml.Controls.PasswordBox.PasswordBox()
		// Forced skipping of method Microsoft.UI.Xaml.Controls.PasswordBox.PasswordBox()
		// Forced skipping of method Microsoft.UI.Xaml.Controls.PasswordBox.Password.get
		// Forced skipping of method Microsoft.UI.Xaml.Controls.PasswordBox.Password.set
		// Forced skipping of method Microsoft.UI.Xaml.Controls.PasswordBox.PasswordChar.get
		// Forced skipping of method Microsoft.UI.Xaml.Controls.PasswordBox.PasswordChar.set
		// Forced skipping of method Microsoft.UI.Xaml.Controls.PasswordBox.IsPasswordRevealButtonEnabled.get
		// Forced skipping of method Microsoft.UI.Xaml.Controls.PasswordBox.IsPasswordRevealButtonEnabled.set
		// Forced skipping of method Microsoft.UI.Xaml.Controls.PasswordBox.MaxLength.get
		// Forced skipping of method Microsoft.UI.Xaml.Controls.PasswordBox.MaxLength.set
		// Forced skipping of method Microsoft.UI.Xaml.Controls.PasswordBox.Header.get
		// Forced skipping of method Microsoft.UI.Xaml.Controls.PasswordBox.Header.set
		// Forced skipping of method Microsoft.UI.Xaml.Controls.PasswordBox.HeaderTemplate.get
		// Forced skipping of method Microsoft.UI.Xaml.Controls.PasswordBox.HeaderTemplate.set
		// Forced skipping of method Microsoft.UI.Xaml.Controls.PasswordBox.PlaceholderText.get
		// Forced skipping of method Microsoft.UI.Xaml.Controls.PasswordBox.PlaceholderText.set
		// Forced skipping of method Microsoft.UI.Xaml.Controls.PasswordBox.SelectionHighlightColor.get
		// Forced skipping of method Microsoft.UI.Xaml.Controls.PasswordBox.SelectionHighlightColor.set
		// Forced skipping of method Microsoft.UI.Xaml.Controls.PasswordBox.PreventKeyboardDisplayOnProgrammaticFocus.get
		// Forced skipping of method Microsoft.UI.Xaml.Controls.PasswordBox.PreventKeyboardDisplayOnProgrammaticFocus.set
		// Forced skipping of method Microsoft.UI.Xaml.Controls.PasswordBox.PasswordRevealMode.get
		// Forced skipping of method Microsoft.UI.Xaml.Controls.PasswordBox.PasswordRevealMode.set
		// Forced skipping of method Microsoft.UI.Xaml.Controls.PasswordBox.TextReadingOrder.get
		// Forced skipping of method Microsoft.UI.Xaml.Controls.PasswordBox.TextReadingOrder.set
		// Forced skipping of method Microsoft.UI.Xaml.Controls.PasswordBox.InputScope.get
		// Forced skipping of method Microsoft.UI.Xaml.Controls.PasswordBox.InputScope.set
		// Forced skipping of method Microsoft.UI.Xaml.Controls.PasswordBox.CanPasteClipboardContent.get
		// Forced skipping of method Microsoft.UI.Xaml.Controls.PasswordBox.SelectionFlyout.get
		// Forced skipping of method Microsoft.UI.Xaml.Controls.PasswordBox.SelectionFlyout.set
		// Forced skipping of method Microsoft.UI.Xaml.Controls.PasswordBox.Description.get
		// Forced skipping of method Microsoft.UI.Xaml.Controls.PasswordBox.Description.set
		// Forced skipping of method Microsoft.UI.Xaml.Controls.PasswordBox.PasswordChanged.add
		// Forced skipping of method Microsoft.UI.Xaml.Controls.PasswordBox.PasswordChanged.remove
		// Forced skipping of method Microsoft.UI.Xaml.Controls.PasswordBox.ContextMenuOpening.add
		// Forced skipping of method Microsoft.UI.Xaml.Controls.PasswordBox.ContextMenuOpening.remove
		// Forced skipping of method Microsoft.UI.Xaml.Controls.PasswordBox.Paste.add
		// Forced skipping of method Microsoft.UI.Xaml.Controls.PasswordBox.Paste.remove
		// Forced skipping of method Microsoft.UI.Xaml.Controls.PasswordBox.PasswordChanging.add
		// Forced skipping of method Microsoft.UI.Xaml.Controls.PasswordBox.PasswordChanging.remove
		// Skipping already declared method Microsoft.UI.Xaml.Controls.PasswordBox.SelectAll()
		// Skipping already declared method Microsoft.UI.Xaml.Controls.PasswordBox.PasteFromClipboard()
		// Forced skipping of method Microsoft.UI.Xaml.Controls.PasswordBox.PasswordProperty.get
		// Forced skipping of method Microsoft.UI.Xaml.Controls.PasswordBox.PasswordCharProperty.get
		// Forced skipping of method Microsoft.UI.Xaml.Controls.PasswordBox.IsPasswordRevealButtonEnabledProperty.get
		// Forced skipping of method Microsoft.UI.Xaml.Controls.PasswordBox.MaxLengthProperty.get
		// Forced skipping of method Microsoft.UI.Xaml.Controls.PasswordBox.HeaderProperty.get
		// Forced skipping of method Microsoft.UI.Xaml.Controls.PasswordBox.HeaderTemplateProperty.get
		// Forced skipping of method Microsoft.UI.Xaml.Controls.PasswordBox.PlaceholderTextProperty.get
		// Forced skipping of method Microsoft.UI.Xaml.Controls.PasswordBox.SelectionHighlightColorProperty.get
		// Forced skipping of method Microsoft.UI.Xaml.Controls.PasswordBox.PreventKeyboardDisplayOnProgrammaticFocusProperty.get
		// Forced skipping of method Microsoft.UI.Xaml.Controls.PasswordBox.PasswordRevealModeProperty.get
		// Forced skipping of method Microsoft.UI.Xaml.Controls.PasswordBox.TextReadingOrderProperty.get
		// Forced skipping of method Microsoft.UI.Xaml.Controls.PasswordBox.InputScopeProperty.get
		// Forced skipping of method Microsoft.UI.Xaml.Controls.PasswordBox.CanPasteClipboardContentProperty.get
		// Forced skipping of method Microsoft.UI.Xaml.Controls.PasswordBox.SelectionFlyoutProperty.get
		// Forced skipping of method Microsoft.UI.Xaml.Controls.PasswordBox.DescriptionProperty.get
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "NET461", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  event global::Microsoft.UI.Xaml.Controls.ContextMenuOpeningEventHandler ContextMenuOpening
		{
			[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "NET461", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
			add
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Microsoft.UI.Xaml.Controls.PasswordBox", "event ContextMenuOpeningEventHandler PasswordBox.ContextMenuOpening");
			}
			[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "NET461", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
			remove
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Microsoft.UI.Xaml.Controls.PasswordBox", "event ContextMenuOpeningEventHandler PasswordBox.ContextMenuOpening");
			}
		}
		#endif
		// Skipping already declared event Microsoft.UI.Xaml.Controls.PasswordBox.PasswordChanged
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "NET461", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  event global::Windows.Foundation.TypedEventHandler<global::Microsoft.UI.Xaml.Controls.PasswordBox, global::Microsoft.UI.Xaml.Controls.PasswordBoxPasswordChangingEventArgs> PasswordChanging
		{
			[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "NET461", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
			add
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Microsoft.UI.Xaml.Controls.PasswordBox", "event TypedEventHandler<PasswordBox, PasswordBoxPasswordChangingEventArgs> PasswordBox.PasswordChanging");
			}
			[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "NET461", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
			remove
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Microsoft.UI.Xaml.Controls.PasswordBox", "event TypedEventHandler<PasswordBox, PasswordBoxPasswordChangingEventArgs> PasswordBox.PasswordChanging");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "NET461", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  event global::Microsoft.UI.Xaml.Controls.TextControlPasteEventHandler Paste
		{
			[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "NET461", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
			add
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Microsoft.UI.Xaml.Controls.PasswordBox", "event TextControlPasteEventHandler PasswordBox.Paste");
			}
			[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "NET461", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
			remove
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Microsoft.UI.Xaml.Controls.PasswordBox", "event TextControlPasteEventHandler PasswordBox.Paste");
			}
		}
		#endif
	}
}
