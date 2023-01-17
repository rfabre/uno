#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Microsoft.UI.Composition
{
	#if false || false || NET461 || __WASM__ || __SKIA__ || false || false
	[global::Uno.NotImplemented("NET461", "__WASM__", "__SKIA__")]
	#endif
	public  partial class CompositionGeometricClip : global::Microsoft.UI.Composition.CompositionClip
	{
		#if false || false || false || __WASM__ || false || false || false
		[global::Uno.NotImplemented("__WASM__")]
		public  global::Microsoft.UI.Composition.CompositionViewBox ViewBox
		{
			get
			{
				throw new global::System.NotImplementedException("The member CompositionViewBox CompositionGeometricClip.ViewBox is not implemented in Uno.");
			}
			set
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Microsoft.UI.Composition.CompositionGeometricClip", "CompositionViewBox CompositionGeometricClip.ViewBox");
			}
		}
		#endif
		#if false || false || false || __WASM__ || false || false || false
		[global::Uno.NotImplemented("__WASM__")]
		public  global::Microsoft.UI.Composition.CompositionGeometry Geometry
		{
			get
			{
				throw new global::System.NotImplementedException("The member CompositionGeometry CompositionGeometricClip.Geometry is not implemented in Uno.");
			}
			set
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Microsoft.UI.Composition.CompositionGeometricClip", "CompositionGeometry CompositionGeometricClip.Geometry");
			}
		}
		#endif
		// Forced skipping of method Microsoft.UI.Composition.CompositionGeometricClip.ViewBox.set
		// Forced skipping of method Microsoft.UI.Composition.CompositionGeometricClip.Geometry.get
		// Forced skipping of method Microsoft.UI.Composition.CompositionGeometricClip.Geometry.set
		// Forced skipping of method Microsoft.UI.Composition.CompositionGeometricClip.ViewBox.get
	}
}
