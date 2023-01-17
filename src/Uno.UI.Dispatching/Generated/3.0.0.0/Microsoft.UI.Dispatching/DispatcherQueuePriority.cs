#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Microsoft.UI.Dispatching
{
	#if false || false || NET461 || __WASM__ || __SKIA__ || false || false
	public   enum DispatcherQueuePriority 
	{
		#if false || false || false || __WASM__ || false || false || false
		Low = -10,
		#endif
		#if false || false || false || __WASM__ || false || false || false
		Normal = 0,
		#endif
		#if false || false || false || __WASM__ || false || false || false
		High = 10,
		#endif
	}
	#endif
}
