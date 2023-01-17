#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Microsoft.UI.Dispatching
{
	#if false || false || NET461 || __WASM__ || __SKIA__ || false || false
	public delegate void DispatcherQueueHandler();
	#endif
}
