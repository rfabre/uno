#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Microsoft.UI.Composition
{
	#if false || false || NET461 || __WASM__ || __SKIA__ || false || false
	[global::Uno.NotImplemented("NET461", "__WASM__", "__SKIA__")]
	#endif
	public  partial class CompositionLinearGradientBrush : global::Microsoft.UI.Composition.CompositionGradientBrush
	{
		#if false || false || false || __WASM__ || false || false || false
		[global::Uno.NotImplemented("__WASM__")]
		public  global::System.Numerics.Vector2 StartPoint
		{
			get
			{
				throw new global::System.NotImplementedException("The member Vector2 CompositionLinearGradientBrush.StartPoint is not implemented in Uno.");
			}
			set
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Microsoft.UI.Composition.CompositionLinearGradientBrush", "Vector2 CompositionLinearGradientBrush.StartPoint");
			}
		}
		#endif
		#if false || false || false || __WASM__ || false || false || false
		[global::Uno.NotImplemented("__WASM__")]
		public  global::System.Numerics.Vector2 EndPoint
		{
			get
			{
				throw new global::System.NotImplementedException("The member Vector2 CompositionLinearGradientBrush.EndPoint is not implemented in Uno.");
			}
			set
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Microsoft.UI.Composition.CompositionLinearGradientBrush", "Vector2 CompositionLinearGradientBrush.EndPoint");
			}
		}
		#endif
		// Forced skipping of method Microsoft.UI.Composition.CompositionLinearGradientBrush.StartPoint.get
		// Forced skipping of method Microsoft.UI.Composition.CompositionLinearGradientBrush.StartPoint.set
		// Forced skipping of method Microsoft.UI.Composition.CompositionLinearGradientBrush.EndPoint.get
		// Forced skipping of method Microsoft.UI.Composition.CompositionLinearGradientBrush.EndPoint.set
	}
}
