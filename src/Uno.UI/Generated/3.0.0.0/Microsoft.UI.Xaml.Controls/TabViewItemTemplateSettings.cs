#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Microsoft.UI.Xaml.Controls
{
	#if false || false || false || false || false || false || false
	[global::Uno.NotImplemented]
	#endif
	public  partial class TabViewItemTemplateSettings : global::Microsoft.UI.Xaml.DependencyObject
	{
		// Skipping already declared property IconElement
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "NET461", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  global::Microsoft.UI.Xaml.Media.Geometry TabGeometry
		{
			get
			{
				return (global::Microsoft.UI.Xaml.Media.Geometry)this.GetValue(TabGeometryProperty);
			}
			set
			{
				this.SetValue(TabGeometryProperty, value);
			}
		}
		#endif
		// Skipping already declared property IconElementProperty
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "NET461", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public static global::Microsoft.UI.Xaml.DependencyProperty TabGeometryProperty { get; } = 
		Microsoft.UI.Xaml.DependencyProperty.Register(
			nameof(TabGeometry), typeof(global::Microsoft.UI.Xaml.Media.Geometry), 
			typeof(global::Microsoft.UI.Xaml.Controls.TabViewItemTemplateSettings), 
			new FrameworkPropertyMetadata(default(global::Microsoft.UI.Xaml.Media.Geometry)));
		#endif
		// Skipping already declared method Microsoft.UI.Xaml.Controls.TabViewItemTemplateSettings.TabViewItemTemplateSettings()
		// Forced skipping of method Microsoft.UI.Xaml.Controls.TabViewItemTemplateSettings.TabViewItemTemplateSettings()
		// Forced skipping of method Microsoft.UI.Xaml.Controls.TabViewItemTemplateSettings.IconElement.get
		// Forced skipping of method Microsoft.UI.Xaml.Controls.TabViewItemTemplateSettings.IconElement.set
		// Forced skipping of method Microsoft.UI.Xaml.Controls.TabViewItemTemplateSettings.TabGeometry.get
		// Forced skipping of method Microsoft.UI.Xaml.Controls.TabViewItemTemplateSettings.TabGeometry.set
		// Forced skipping of method Microsoft.UI.Xaml.Controls.TabViewItemTemplateSettings.TabGeometryProperty.get
		// Forced skipping of method Microsoft.UI.Xaml.Controls.TabViewItemTemplateSettings.IconElementProperty.get
	}
}
