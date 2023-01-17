#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Microsoft.UI.Composition
{
	#if false || false || NET461 || __WASM__ || __SKIA__ || false || false
	[global::System.FlagsAttribute]
	public   enum CompositionBatchTypes : uint
	{
		#if false || false || false || __WASM__ || false || false || false
		None = 0,
		#endif
		#if false || false || false || __WASM__ || false || false || false
		Animation = 1,
		#endif
		#if false || false || false || __WASM__ || false || false || false
		Effect = 2,
		#endif
		#if false || false || false || __WASM__ || false || false || false
		InfiniteAnimation = 4,
		#endif
		#if false || false || false || __WASM__ || false || false || false
		AllAnimations = 5,
		#endif
	}
	#endif
}
