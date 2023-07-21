#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Windows.UI.WindowManagement
{
	#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
	[global::Uno.NotImplemented]
	#endif
	public  partial class AppWindowPresenter 
	{
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  global::Windows.UI.WindowManagement.AppWindowPresentationConfiguration GetConfiguration()
		{
			throw new global::System.NotImplementedException("The member AppWindowPresentationConfiguration AppWindowPresenter.GetConfiguration() is not implemented. For more information, visit https://aka.platform.uno/notimplemented?m=AppWindowPresentationConfiguration%20AppWindowPresenter.GetConfiguration%28%29");
		}
		#endif
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  bool IsPresentationSupported( global::Windows.UI.WindowManagement.AppWindowPresentationKind presentationKind)
		{
			throw new global::System.NotImplementedException("The member bool AppWindowPresenter.IsPresentationSupported(AppWindowPresentationKind presentationKind) is not implemented. For more information, visit https://aka.platform.uno/notimplemented?m=bool%20AppWindowPresenter.IsPresentationSupported%28AppWindowPresentationKind%20presentationKind%29");
		}
		#endif
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  bool RequestPresentation( global::Windows.UI.WindowManagement.AppWindowPresentationConfiguration configuration)
		{
			throw new global::System.NotImplementedException("The member bool AppWindowPresenter.RequestPresentation(AppWindowPresentationConfiguration configuration) is not implemented. For more information, visit https://aka.platform.uno/notimplemented?m=bool%20AppWindowPresenter.RequestPresentation%28AppWindowPresentationConfiguration%20configuration%29");
		}
		#endif
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  bool RequestPresentation( global::Windows.UI.WindowManagement.AppWindowPresentationKind presentationKind)
		{
			throw new global::System.NotImplementedException("The member bool AppWindowPresenter.RequestPresentation(AppWindowPresentationKind presentationKind) is not implemented. For more information, visit https://aka.platform.uno/notimplemented?m=bool%20AppWindowPresenter.RequestPresentation%28AppWindowPresentationKind%20presentationKind%29");
		}
		#endif
	}
}
