#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Microsoft.UI.Composition
{
	#if false || false || NET461 || __WASM__ || __SKIA__ || false || false
	[global::Uno.NotImplemented("NET461", "__WASM__", "__SKIA__")]
	#endif
	public  partial class ShapeVisual : global::Microsoft.UI.Composition.ContainerVisual
	{
		#if false || false || false || __WASM__ || false || false || false
		[global::Uno.NotImplemented("__WASM__")]
		public  global::Microsoft.UI.Composition.CompositionViewBox ViewBox
		{
			get
			{
				throw new global::System.NotImplementedException("The member CompositionViewBox ShapeVisual.ViewBox is not implemented in Uno.");
			}
			set
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Microsoft.UI.Composition.ShapeVisual", "CompositionViewBox ShapeVisual.ViewBox");
			}
		}
		#endif
		#if false || false || false || __WASM__ || false || false || false
		[global::Uno.NotImplemented("__WASM__")]
		public  global::Microsoft.UI.Composition.CompositionShapeCollection Shapes
		{
			get
			{
				throw new global::System.NotImplementedException("The member CompositionShapeCollection ShapeVisual.Shapes is not implemented in Uno.");
			}
		}
		#endif
		// Forced skipping of method Microsoft.UI.Composition.ShapeVisual.Shapes.get
		// Forced skipping of method Microsoft.UI.Composition.ShapeVisual.ViewBox.get
		// Forced skipping of method Microsoft.UI.Composition.ShapeVisual.ViewBox.set
	}
}
