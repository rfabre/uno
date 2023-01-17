#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Microsoft.UI.Composition
{
	#if false || false || NET461 || __WASM__ || __SKIA__ || false || false
	[global::Uno.NotImplemented("NET461", "__WASM__", "__SKIA__")]
	#endif
	public  partial class ContainerVisual : global::Microsoft.UI.Composition.Visual
	{
		#if false || false || false || __WASM__ || false || false || false
		[global::Uno.NotImplemented("__WASM__")]
		public  global::Microsoft.UI.Composition.VisualCollection Children
		{
			get
			{
				throw new global::System.NotImplementedException("The member VisualCollection ContainerVisual.Children is not implemented in Uno.");
			}
		}
		#endif
		// Forced skipping of method Microsoft.UI.Composition.ContainerVisual.Children.get
	}
}
