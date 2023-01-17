#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Microsoft.UI.Composition
{
	#if false || false || NET461 || __WASM__ || __SKIA__ || false || false
	[global::Uno.NotImplemented("NET461", "__WASM__", "__SKIA__")]
	#endif
	public  partial class CompositionEllipseGeometry : global::Microsoft.UI.Composition.CompositionGeometry
	{
		#if false || false || false || __WASM__ || false || false || false
		[global::Uno.NotImplemented("__WASM__")]
		public  global::System.Numerics.Vector2 Radius
		{
			get
			{
				throw new global::System.NotImplementedException("The member Vector2 CompositionEllipseGeometry.Radius is not implemented in Uno.");
			}
			set
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Microsoft.UI.Composition.CompositionEllipseGeometry", "Vector2 CompositionEllipseGeometry.Radius");
			}
		}
		#endif
		#if false || false || false || __WASM__ || false || false || false
		[global::Uno.NotImplemented("__WASM__")]
		public  global::System.Numerics.Vector2 Center
		{
			get
			{
				throw new global::System.NotImplementedException("The member Vector2 CompositionEllipseGeometry.Center is not implemented in Uno.");
			}
			set
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Microsoft.UI.Composition.CompositionEllipseGeometry", "Vector2 CompositionEllipseGeometry.Center");
			}
		}
		#endif
		// Forced skipping of method Microsoft.UI.Composition.CompositionEllipseGeometry.Radius.set
		// Forced skipping of method Microsoft.UI.Composition.CompositionEllipseGeometry.Radius.get
		// Forced skipping of method Microsoft.UI.Composition.CompositionEllipseGeometry.Center.set
		// Forced skipping of method Microsoft.UI.Composition.CompositionEllipseGeometry.Center.get
	}
}
