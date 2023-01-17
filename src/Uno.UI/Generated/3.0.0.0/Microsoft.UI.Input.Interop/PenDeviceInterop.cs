#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Microsoft.UI.Input.Interop
{
	#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
	[global::Uno.NotImplemented]
	#endif
	public static partial class PenDeviceInterop 
	{
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "NET461", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public static global::Windows.Devices.Input.PenDevice FromPointerPoint( global::Microsoft.UI.Input.PointerPoint pointerPoint)
		{
			throw new global::System.NotImplementedException("The member PenDevice PenDeviceInterop.FromPointerPoint(PointerPoint pointerPoint) is not implemented in Uno.");
		}
		#endif
	}
}
