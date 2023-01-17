#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Microsoft.UI.Composition
{
	#if false || false || NET461 || __WASM__ || __SKIA__ || false || false
	[global::Uno.NotImplemented("NET461", "__WASM__", "__SKIA__")]
	#endif
	public  partial class CompositionLineGeometry : global::Microsoft.UI.Composition.CompositionGeometry
	{
		#if false || false || false || __WASM__ || false || false || false
		[global::Uno.NotImplemented("__WASM__")]
		public  global::System.Numerics.Vector2 Start
		{
			get
			{
				throw new global::System.NotImplementedException("The member Vector2 CompositionLineGeometry.Start is not implemented in Uno.");
			}
			set
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Microsoft.UI.Composition.CompositionLineGeometry", "Vector2 CompositionLineGeometry.Start");
			}
		}
		#endif
		#if false || false || false || __WASM__ || false || false || false
		[global::Uno.NotImplemented("__WASM__")]
		public  global::System.Numerics.Vector2 End
		{
			get
			{
				throw new global::System.NotImplementedException("The member Vector2 CompositionLineGeometry.End is not implemented in Uno.");
			}
			set
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Microsoft.UI.Composition.CompositionLineGeometry", "Vector2 CompositionLineGeometry.End");
			}
		}
		#endif
		// Forced skipping of method Microsoft.UI.Composition.CompositionLineGeometry.End.get
		// Forced skipping of method Microsoft.UI.Composition.CompositionLineGeometry.End.set
		// Forced skipping of method Microsoft.UI.Composition.CompositionLineGeometry.Start.set
		// Forced skipping of method Microsoft.UI.Composition.CompositionLineGeometry.Start.get
	}
}
