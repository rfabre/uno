#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Windows.UI.Xaml
{
	#if false || false || false || false || false || false || false
	[global::Uno.NotImplemented]
	#endif
	public  partial class MediaFailedRoutedEventArgs : global::Windows.UI.Xaml.ExceptionRoutedEventArgs
	{
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  string ErrorTrace
		{
			get
			{
				throw new global::System.NotImplementedException("The member string MediaFailedRoutedEventArgs.ErrorTrace is not implemented. For more information, visit https://aka.platform.uno/notimplemented?m=string%20MediaFailedRoutedEventArgs.ErrorTrace");
			}
		}
		#endif
		// Forced skipping of method Windows.UI.Xaml.MediaFailedRoutedEventArgs.ErrorTrace.get
	}
}
