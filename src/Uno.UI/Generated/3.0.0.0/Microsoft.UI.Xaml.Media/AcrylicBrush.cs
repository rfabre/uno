#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Microsoft.UI.Xaml.Media
{
	#if false || false || false || false || false || false || false
	[global::Uno.NotImplemented]
	#endif
	public  partial class AcrylicBrush : global::Microsoft.UI.Xaml.Media.XamlCompositionBrushBase
	{
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "NET461", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  global::System.TimeSpan TintTransitionDuration
		{
			get
			{
				return (global::System.TimeSpan)this.GetValue(TintTransitionDurationProperty);
			}
			set
			{
				this.SetValue(TintTransitionDurationProperty, value);
			}
		}
		#endif
		// Skipping already declared property TintOpacity
		// Skipping already declared property TintColor
		// Skipping already declared property AlwaysUseFallback
		// Skipping already declared property TintLuminosityOpacity
		// Skipping already declared property AlwaysUseFallbackProperty
		// Skipping already declared property TintColorProperty
		// Skipping already declared property TintOpacityProperty
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "NET461", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public static global::Microsoft.UI.Xaml.DependencyProperty TintTransitionDurationProperty { get; } = 
		Microsoft.UI.Xaml.DependencyProperty.Register(
			nameof(TintTransitionDuration), typeof(global::System.TimeSpan), 
			typeof(global::Microsoft.UI.Xaml.Media.AcrylicBrush), 
			new Microsoft.UI.Xaml.FrameworkPropertyMetadata(default(global::System.TimeSpan)));
		#endif
		// Skipping already declared property TintLuminosityOpacityProperty
		// Skipping already declared method Microsoft.UI.Xaml.Media.AcrylicBrush.AcrylicBrush()
		// Forced skipping of method Microsoft.UI.Xaml.Media.AcrylicBrush.AcrylicBrush()
		// Forced skipping of method Microsoft.UI.Xaml.Media.AcrylicBrush.TintColor.get
		// Forced skipping of method Microsoft.UI.Xaml.Media.AcrylicBrush.TintColor.set
		// Forced skipping of method Microsoft.UI.Xaml.Media.AcrylicBrush.TintOpacity.get
		// Forced skipping of method Microsoft.UI.Xaml.Media.AcrylicBrush.TintOpacity.set
		// Forced skipping of method Microsoft.UI.Xaml.Media.AcrylicBrush.TintTransitionDuration.get
		// Forced skipping of method Microsoft.UI.Xaml.Media.AcrylicBrush.TintTransitionDuration.set
		// Forced skipping of method Microsoft.UI.Xaml.Media.AcrylicBrush.AlwaysUseFallback.get
		// Forced skipping of method Microsoft.UI.Xaml.Media.AcrylicBrush.AlwaysUseFallback.set
		// Forced skipping of method Microsoft.UI.Xaml.Media.AcrylicBrush.TintLuminosityOpacity.get
		// Forced skipping of method Microsoft.UI.Xaml.Media.AcrylicBrush.TintLuminosityOpacity.set
		// Forced skipping of method Microsoft.UI.Xaml.Media.AcrylicBrush.TintLuminosityOpacityProperty.get
		// Forced skipping of method Microsoft.UI.Xaml.Media.AcrylicBrush.TintColorProperty.get
		// Forced skipping of method Microsoft.UI.Xaml.Media.AcrylicBrush.TintOpacityProperty.get
		// Forced skipping of method Microsoft.UI.Xaml.Media.AcrylicBrush.TintTransitionDurationProperty.get
		// Forced skipping of method Microsoft.UI.Xaml.Media.AcrylicBrush.AlwaysUseFallbackProperty.get
	}
}
