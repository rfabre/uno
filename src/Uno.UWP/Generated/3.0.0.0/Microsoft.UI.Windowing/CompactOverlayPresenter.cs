#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Microsoft.UI.Windowing
{
	#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || false
	[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "NET461", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__")]
	#endif
	public  partial class CompactOverlayPresenter : global::Microsoft.UI.Windowing.AppWindowPresenter
	{
		#if __ANDROID__ || __IOS__ || false || __WASM__ || false || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "__WASM__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  global::Microsoft.UI.Windowing.CompactOverlaySize InitialSize
		{
			get
			{
				throw new global::System.NotImplementedException("The member CompactOverlaySize CompactOverlayPresenter.InitialSize is not implemented in Uno.");
			}
			set
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Microsoft.UI.Windowing.CompactOverlayPresenter", "CompactOverlaySize CompactOverlayPresenter.InitialSize");
			}
		}
		#endif
		// Forced skipping of method Microsoft.UI.Windowing.CompactOverlayPresenter.InitialSize.set
		// Forced skipping of method Microsoft.UI.Windowing.CompactOverlayPresenter.InitialSize.get
		#if __ANDROID__ || __IOS__ || false || __WASM__ || false || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "__WASM__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public static global::Microsoft.UI.Windowing.CompactOverlayPresenter Create()
		{
			throw new global::System.NotImplementedException("The member CompactOverlayPresenter CompactOverlayPresenter.Create() is not implemented in Uno.");
		}
		#endif
	}
}
