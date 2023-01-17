#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Microsoft.UI.Composition
{
	#if false || false || NET461 || __WASM__ || __SKIA__ || false || false
	[global::Uno.NotImplemented("NET461", "__WASM__", "__SKIA__")]
	#endif
	public  partial class CompositionPath 
	{
		#if false || false || false || __WASM__ || false || false || false
		[global::Uno.NotImplemented("__WASM__")]
		public CompositionPath( global::Windows.Graphics.IGeometrySource2D source) 
		{
			global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Microsoft.UI.Composition.CompositionPath", "CompositionPath.CompositionPath(IGeometrySource2D source)");
		}
		#endif
		// Forced skipping of method Microsoft.UI.Composition.CompositionPath.CompositionPath(Windows.Graphics.IGeometrySource2D)
	}
}
