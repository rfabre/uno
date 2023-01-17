#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Microsoft.UI.Composition
{
	#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || false
	[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "NET461", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__")]
	#endif
	public  partial class SpringScalarNaturalMotionAnimation : global::Microsoft.UI.Composition.ScalarNaturalMotionAnimation
	{
		#if __ANDROID__ || __IOS__ || false || __WASM__ || false || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "__WASM__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  global::System.TimeSpan Period
		{
			get
			{
				throw new global::System.NotImplementedException("The member TimeSpan SpringScalarNaturalMotionAnimation.Period is not implemented in Uno.");
			}
			set
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Microsoft.UI.Composition.SpringScalarNaturalMotionAnimation", "TimeSpan SpringScalarNaturalMotionAnimation.Period");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || false || __WASM__ || false || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "__WASM__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  float DampingRatio
		{
			get
			{
				throw new global::System.NotImplementedException("The member float SpringScalarNaturalMotionAnimation.DampingRatio is not implemented in Uno.");
			}
			set
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Microsoft.UI.Composition.SpringScalarNaturalMotionAnimation", "float SpringScalarNaturalMotionAnimation.DampingRatio");
			}
		}
		#endif
		// Forced skipping of method Microsoft.UI.Composition.SpringScalarNaturalMotionAnimation.DampingRatio.get
		// Forced skipping of method Microsoft.UI.Composition.SpringScalarNaturalMotionAnimation.Period.set
		// Forced skipping of method Microsoft.UI.Composition.SpringScalarNaturalMotionAnimation.DampingRatio.set
		// Forced skipping of method Microsoft.UI.Composition.SpringScalarNaturalMotionAnimation.Period.get
	}
}
