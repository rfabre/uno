#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Microsoft.UI.Input
{
	#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
	[global::Uno.NotImplemented]
	#endif
	public  partial class InputDesktopNamedResourceCursor : global::Microsoft.UI.Input.InputCursor
	{
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "NET461", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  string ModuleName
		{
			get
			{
				throw new global::System.NotImplementedException("The member string InputDesktopNamedResourceCursor.ModuleName is not implemented. For more information, visit https://aka.platform.uno/notimplemented?m=string%20InputDesktopNamedResourceCursor.ModuleName");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "NET461", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  string ResourceName
		{
			get
			{
				throw new global::System.NotImplementedException("The member string InputDesktopNamedResourceCursor.ResourceName is not implemented. For more information, visit https://aka.platform.uno/notimplemented?m=string%20InputDesktopNamedResourceCursor.ResourceName");
			}
		}
		#endif
		// Forced skipping of method Microsoft.UI.Input.InputDesktopNamedResourceCursor.ModuleName.get
		// Forced skipping of method Microsoft.UI.Input.InputDesktopNamedResourceCursor.ResourceName.get
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "NET461", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public static global::Microsoft.UI.Input.InputDesktopNamedResourceCursor Create( string resourceName)
		{
			throw new global::System.NotImplementedException("The member InputDesktopNamedResourceCursor InputDesktopNamedResourceCursor.Create(string resourceName) is not implemented. For more information, visit https://aka.platform.uno/notimplemented?m=InputDesktopNamedResourceCursor%20InputDesktopNamedResourceCursor.Create%28string%20resourceName%29");
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "NET461", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public static global::Microsoft.UI.Input.InputDesktopNamedResourceCursor CreateFromModule( string moduleName,  string resourceName)
		{
			throw new global::System.NotImplementedException("The member InputDesktopNamedResourceCursor InputDesktopNamedResourceCursor.CreateFromModule(string moduleName, string resourceName) is not implemented. For more information, visit https://aka.platform.uno/notimplemented?m=InputDesktopNamedResourceCursor%20InputDesktopNamedResourceCursor.CreateFromModule%28string%20moduleName%2C%20string%20resourceName%29");
		}
		#endif
	}
}
