#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Windows.UI.Composition
{
	#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
	[global::Uno.NotImplemented]
	#endif
	public  partial interface ICompositionSupportsSystemBackdrop 
	{
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		global::Windows.UI.Composition.CompositionBrush SystemBackdrop
		{
			get;
			set;
		}
		#endif
		// Forced skipping of method Windows.UI.Composition.ICompositionSupportsSystemBackdrop.SystemBackdrop.get
		// Forced skipping of method Windows.UI.Composition.ICompositionSupportsSystemBackdrop.SystemBackdrop.set
	}
}
