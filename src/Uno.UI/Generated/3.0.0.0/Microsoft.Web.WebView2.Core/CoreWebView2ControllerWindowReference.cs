#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Microsoft.Web.WebView2.Core
{
	#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
	[global::Uno.NotImplemented]
	#endif
	public  partial class CoreWebView2ControllerWindowReference 
	{
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  global::Windows.UI.Core.CoreWindow CoreWindow
		{
			get
			{
				throw new global::System.NotImplementedException("The member CoreWindow CoreWebView2ControllerWindowReference.CoreWindow is not implemented. For more information, visit https://aka.platform.uno/notimplemented?m=CoreWindow%20CoreWebView2ControllerWindowReference.CoreWindow");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  ulong WindowHandle
		{
			get
			{
				throw new global::System.NotImplementedException("The member ulong CoreWebView2ControllerWindowReference.WindowHandle is not implemented. For more information, visit https://aka.platform.uno/notimplemented?m=ulong%20CoreWebView2ControllerWindowReference.WindowHandle");
			}
		}
		#endif
		// Forced skipping of method Microsoft.Web.WebView2.Core.CoreWebView2ControllerWindowReference.WindowHandle.get
		// Forced skipping of method Microsoft.Web.WebView2.Core.CoreWebView2ControllerWindowReference.CoreWindow.get
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public static global::Microsoft.Web.WebView2.Core.CoreWebView2ControllerWindowReference CreateFromWindowHandle( ulong windowHandle)
		{
			throw new global::System.NotImplementedException("The member CoreWebView2ControllerWindowReference CoreWebView2ControllerWindowReference.CreateFromWindowHandle(ulong windowHandle) is not implemented. For more information, visit https://aka.platform.uno/notimplemented?m=CoreWebView2ControllerWindowReference%20CoreWebView2ControllerWindowReference.CreateFromWindowHandle%28ulong%20windowHandle%29");
		}
		#endif
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public static global::Microsoft.Web.WebView2.Core.CoreWebView2ControllerWindowReference CreateFromCoreWindow( global::Windows.UI.Core.CoreWindow coreWindow)
		{
			throw new global::System.NotImplementedException("The member CoreWebView2ControllerWindowReference CoreWebView2ControllerWindowReference.CreateFromCoreWindow(CoreWindow coreWindow) is not implemented. For more information, visit https://aka.platform.uno/notimplemented?m=CoreWebView2ControllerWindowReference%20CoreWebView2ControllerWindowReference.CreateFromCoreWindow%28CoreWindow%20coreWindow%29");
		}
		#endif
	}
}
