#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Microsoft.UI.Composition
{
	#if false || false || NET461 || __WASM__ || __SKIA__ || false || false
	[global::Uno.NotImplemented("NET461", "__WASM__", "__SKIA__")]
	#endif
	public  partial class CompositionColorGradientStop : global::Microsoft.UI.Composition.CompositionObject
	{
		#if false || false || false || __WASM__ || false || false || false
		[global::Uno.NotImplemented("__WASM__")]
		public  float Offset
		{
			get
			{
				throw new global::System.NotImplementedException("The member float CompositionColorGradientStop.Offset is not implemented in Uno.");
			}
			set
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Microsoft.UI.Composition.CompositionColorGradientStop", "float CompositionColorGradientStop.Offset");
			}
		}
		#endif
		#if false || false || false || __WASM__ || false || false || false
		[global::Uno.NotImplemented("__WASM__")]
		public  global::Windows.UI.Color Color
		{
			get
			{
				throw new global::System.NotImplementedException("The member Color CompositionColorGradientStop.Color is not implemented in Uno.");
			}
			set
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Microsoft.UI.Composition.CompositionColorGradientStop", "Color CompositionColorGradientStop.Color");
			}
		}
		#endif
		// Forced skipping of method Microsoft.UI.Composition.CompositionColorGradientStop.Offset.set
		// Forced skipping of method Microsoft.UI.Composition.CompositionColorGradientStop.Color.get
		// Forced skipping of method Microsoft.UI.Composition.CompositionColorGradientStop.Color.set
		// Forced skipping of method Microsoft.UI.Composition.CompositionColorGradientStop.Offset.get
	}
}
