#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Windows.UI.Composition
{
	#if false || false || false || false || false || false || false
	[global::Uno.NotImplemented]
	#endif
	public  partial class SpriteVisual : global::Windows.UI.Composition.ContainerVisual
	{
		// Skipping already declared property Brush
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  global::Windows.UI.Composition.CompositionShadow Shadow
		{
			get
			{
				throw new global::System.NotImplementedException("The member CompositionShadow SpriteVisual.Shadow is not implemented. For more information, visit https://aka.platform.uno/notimplemented?m=CompositionShadow%20SpriteVisual.Shadow");
			}
			set
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.UI.Composition.SpriteVisual", "CompositionShadow SpriteVisual.Shadow");
			}
		}
		#endif
		// Forced skipping of method Windows.UI.Composition.SpriteVisual.Brush.get
		// Forced skipping of method Windows.UI.Composition.SpriteVisual.Brush.set
		// Forced skipping of method Windows.UI.Composition.SpriteVisual.Shadow.get
		// Forced skipping of method Windows.UI.Composition.SpriteVisual.Shadow.set
	}
}
