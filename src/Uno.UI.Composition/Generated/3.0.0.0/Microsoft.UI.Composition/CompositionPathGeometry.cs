#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Microsoft.UI.Composition
{
	#if false || false || NET461 || __WASM__ || __SKIA__ || false || false
	[global::Uno.NotImplemented("NET461", "__WASM__", "__SKIA__")]
	#endif
	public  partial class CompositionPathGeometry : global::Microsoft.UI.Composition.CompositionGeometry
	{
		#if false || false || false || __WASM__ || false || false || false
		[global::Uno.NotImplemented("__WASM__")]
		public  global::Microsoft.UI.Composition.CompositionPath Path
		{
			get
			{
				throw new global::System.NotImplementedException("The member CompositionPath CompositionPathGeometry.Path is not implemented in Uno.");
			}
			set
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Microsoft.UI.Composition.CompositionPathGeometry", "CompositionPath CompositionPathGeometry.Path");
			}
		}
		#endif
		// Forced skipping of method Microsoft.UI.Composition.CompositionPathGeometry.Path.set
		// Forced skipping of method Microsoft.UI.Composition.CompositionPathGeometry.Path.get
	}
}
