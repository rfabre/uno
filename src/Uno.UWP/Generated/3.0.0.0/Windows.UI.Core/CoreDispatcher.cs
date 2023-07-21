#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Windows.UI.Core
{
	#if false || false || false || false || false || false || false
	[global::Uno.NotImplemented]
	#endif
	public  partial class CoreDispatcher : global::Windows.UI.Core.ICoreAcceleratorKeys
	{
		// Skipping already declared property HasThreadAccess
		// Skipping already declared property CurrentPriority
		// Forced skipping of method Windows.UI.Core.CoreDispatcher.HasThreadAccess.get
		#if __ANDROID__ || __IOS__ || false || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  void ProcessEvents( global::Windows.UI.Core.CoreProcessEventsOption options)
		{
			global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.UI.Core.CoreDispatcher", "void CoreDispatcher.ProcessEvents(CoreProcessEventsOption options)");
		}
		#endif
		// Skipping already declared method Windows.UI.Core.CoreDispatcher.RunAsync(Windows.UI.Core.CoreDispatcherPriority, Windows.UI.Core.DispatchedHandler)
		// Skipping already declared method Windows.UI.Core.CoreDispatcher.RunIdleAsync(Windows.UI.Core.IdleDispatchedHandler)
		// Forced skipping of method Windows.UI.Core.CoreDispatcher.AcceleratorKeyActivated.add
		// Forced skipping of method Windows.UI.Core.CoreDispatcher.AcceleratorKeyActivated.remove
		// Forced skipping of method Windows.UI.Core.CoreDispatcher.CurrentPriority.get
		// Forced skipping of method Windows.UI.Core.CoreDispatcher.CurrentPriority.set
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  bool ShouldYield()
		{
			throw new global::System.NotImplementedException("The member bool CoreDispatcher.ShouldYield() is not implemented. For more information, visit https://aka.platform.uno/notimplemented?m=bool%20CoreDispatcher.ShouldYield%28%29");
		}
		#endif
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  bool ShouldYield( global::Windows.UI.Core.CoreDispatcherPriority priority)
		{
			throw new global::System.NotImplementedException("The member bool CoreDispatcher.ShouldYield(CoreDispatcherPriority priority) is not implemented. For more information, visit https://aka.platform.uno/notimplemented?m=bool%20CoreDispatcher.ShouldYield%28CoreDispatcherPriority%20priority%29");
		}
		#endif
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  void StopProcessEvents()
		{
			global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.UI.Core.CoreDispatcher", "void CoreDispatcher.StopProcessEvents()");
		}
		#endif
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  global::Windows.Foundation.IAsyncOperation<bool> TryRunAsync( global::Windows.UI.Core.CoreDispatcherPriority priority,  global::Windows.UI.Core.DispatchedHandler agileCallback)
		{
			throw new global::System.NotImplementedException("The member IAsyncOperation<bool> CoreDispatcher.TryRunAsync(CoreDispatcherPriority priority, DispatchedHandler agileCallback) is not implemented. For more information, visit https://aka.platform.uno/notimplemented?m=IAsyncOperation%3Cbool%3E%20CoreDispatcher.TryRunAsync%28CoreDispatcherPriority%20priority%2C%20DispatchedHandler%20agileCallback%29");
		}
		#endif
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  global::Windows.Foundation.IAsyncOperation<bool> TryRunIdleAsync( global::Windows.UI.Core.IdleDispatchedHandler agileCallback)
		{
			throw new global::System.NotImplementedException("The member IAsyncOperation<bool> CoreDispatcher.TryRunIdleAsync(IdleDispatchedHandler agileCallback) is not implemented. For more information, visit https://aka.platform.uno/notimplemented?m=IAsyncOperation%3Cbool%3E%20CoreDispatcher.TryRunIdleAsync%28IdleDispatchedHandler%20agileCallback%29");
		}
		#endif
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  event global::Windows.Foundation.TypedEventHandler<global::Windows.UI.Core.CoreDispatcher, global::Windows.UI.Core.AcceleratorKeyEventArgs> AcceleratorKeyActivated
		{
			[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
			add
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.UI.Core.CoreDispatcher", "event TypedEventHandler<CoreDispatcher, AcceleratorKeyEventArgs> CoreDispatcher.AcceleratorKeyActivated");
			}
			[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
			remove
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.UI.Core.CoreDispatcher", "event TypedEventHandler<CoreDispatcher, AcceleratorKeyEventArgs> CoreDispatcher.AcceleratorKeyActivated");
			}
		}
		#endif
		// Processing: Windows.UI.Core.ICoreAcceleratorKeys
	}
}
