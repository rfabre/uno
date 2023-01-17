#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Microsoft.UI.Dispatching
{
	#if false || false || NET461 || __WASM__ || __SKIA__ || false || false
	[global::Uno.NotImplemented("NET461", "__WASM__", "__SKIA__")]
	#endif
	public  partial class DispatcherQueueTimer 
	{
		#if false || false || false || __WASM__ || false || false || false
		[global::Uno.NotImplemented("__WASM__")]
		public  bool IsRepeating
		{
			get
			{
				throw new global::System.NotImplementedException("The member bool DispatcherQueueTimer.IsRepeating is not implemented in Uno.");
			}
			set
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Microsoft.UI.Dispatching.DispatcherQueueTimer", "bool DispatcherQueueTimer.IsRepeating");
			}
		}
		#endif
		#if false || false || false || __WASM__ || false || false || false
		[global::Uno.NotImplemented("__WASM__")]
		public  global::System.TimeSpan Interval
		{
			get
			{
				throw new global::System.NotImplementedException("The member TimeSpan DispatcherQueueTimer.Interval is not implemented in Uno.");
			}
			set
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Microsoft.UI.Dispatching.DispatcherQueueTimer", "TimeSpan DispatcherQueueTimer.Interval");
			}
		}
		#endif
		#if false || false || false || __WASM__ || false || false || false
		[global::Uno.NotImplemented("__WASM__")]
		public  bool IsRunning
		{
			get
			{
				throw new global::System.NotImplementedException("The member bool DispatcherQueueTimer.IsRunning is not implemented in Uno.");
			}
		}
		#endif
		// Forced skipping of method Microsoft.UI.Dispatching.DispatcherQueueTimer.IsRepeating.get
		// Forced skipping of method Microsoft.UI.Dispatching.DispatcherQueueTimer.Interval.set
		// Forced skipping of method Microsoft.UI.Dispatching.DispatcherQueueTimer.IsRunning.get
		// Forced skipping of method Microsoft.UI.Dispatching.DispatcherQueueTimer.Interval.get
		// Forced skipping of method Microsoft.UI.Dispatching.DispatcherQueueTimer.IsRepeating.set
		#if false || false || false || __WASM__ || false || false || false
		[global::Uno.NotImplemented("__WASM__")]
		public  void Start()
		{
			global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Microsoft.UI.Dispatching.DispatcherQueueTimer", "void DispatcherQueueTimer.Start()");
		}
		#endif
		#if false || false || false || __WASM__ || false || false || false
		[global::Uno.NotImplemented("__WASM__")]
		public  void Stop()
		{
			global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Microsoft.UI.Dispatching.DispatcherQueueTimer", "void DispatcherQueueTimer.Stop()");
		}
		#endif
		// Forced skipping of method Microsoft.UI.Dispatching.DispatcherQueueTimer.Tick.add
		// Forced skipping of method Microsoft.UI.Dispatching.DispatcherQueueTimer.Tick.remove
		#if false || false || false || __WASM__ || false || false || false
		[global::Uno.NotImplemented("__WASM__")]
		public  event global::Windows.Foundation.TypedEventHandler<global::Microsoft.UI.Dispatching.DispatcherQueueTimer, object> Tick
		{
			[global::Uno.NotImplemented("__WASM__")]
			add
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Microsoft.UI.Dispatching.DispatcherQueueTimer", "event TypedEventHandler<DispatcherQueueTimer, object> DispatcherQueueTimer.Tick");
			}
			[global::Uno.NotImplemented("__WASM__")]
			remove
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Microsoft.UI.Dispatching.DispatcherQueueTimer", "event TypedEventHandler<DispatcherQueueTimer, object> DispatcherQueueTimer.Tick");
			}
		}
		#endif
	}
}
