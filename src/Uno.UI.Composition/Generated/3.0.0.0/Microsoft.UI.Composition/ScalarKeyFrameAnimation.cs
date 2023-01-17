#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Microsoft.UI.Composition
{
	#if false || false || NET461 || __WASM__ || __SKIA__ || false || false
	[global::Uno.NotImplemented("NET461", "__WASM__", "__SKIA__")]
	#endif
	public  partial class ScalarKeyFrameAnimation : global::Microsoft.UI.Composition.KeyFrameAnimation
	{
		#if false || false || false || __WASM__ || false || false || false
		[global::Uno.NotImplemented("__WASM__")]
		public  void InsertKeyFrame( float normalizedProgressKey,  float value)
		{
			global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Microsoft.UI.Composition.ScalarKeyFrameAnimation", "void ScalarKeyFrameAnimation.InsertKeyFrame(float normalizedProgressKey, float value)");
		}
		#endif
		#if false || false || false || __WASM__ || false || false || false
		[global::Uno.NotImplemented("__WASM__")]
		public  void InsertKeyFrame( float normalizedProgressKey,  float value,  global::Microsoft.UI.Composition.CompositionEasingFunction easingFunction)
		{
			global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Microsoft.UI.Composition.ScalarKeyFrameAnimation", "void ScalarKeyFrameAnimation.InsertKeyFrame(float normalizedProgressKey, float value, CompositionEasingFunction easingFunction)");
		}
		#endif
	}
}
