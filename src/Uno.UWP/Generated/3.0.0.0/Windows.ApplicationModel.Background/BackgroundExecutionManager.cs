#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Windows.ApplicationModel.Background
{
	#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
	[global::Uno.NotImplemented]
	#endif
	public static partial class BackgroundExecutionManager 
	{
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public static global::Windows.Foundation.IAsyncOperation<bool> RequestAccessKindForModernStandbyAsync( global::Windows.ApplicationModel.Background.BackgroundAccessRequestKind requestedAccess,  string reason)
		{
			throw new global::System.NotImplementedException("The member IAsyncOperation<bool> BackgroundExecutionManager.RequestAccessKindForModernStandbyAsync(BackgroundAccessRequestKind requestedAccess, string reason) is not implemented. For more information, visit https://aka.platform.uno/notimplemented?m=IAsyncOperation%3Cbool%3E%20BackgroundExecutionManager.RequestAccessKindForModernStandbyAsync%28BackgroundAccessRequestKind%20requestedAccess%2C%20string%20reason%29");
		}
		#endif
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public static global::Windows.ApplicationModel.Background.BackgroundAccessStatus GetAccessStatusForModernStandby()
		{
			throw new global::System.NotImplementedException("The member BackgroundAccessStatus BackgroundExecutionManager.GetAccessStatusForModernStandby() is not implemented. For more information, visit https://aka.platform.uno/notimplemented?m=BackgroundAccessStatus%20BackgroundExecutionManager.GetAccessStatusForModernStandby%28%29");
		}
		#endif
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public static global::Windows.ApplicationModel.Background.BackgroundAccessStatus GetAccessStatusForModernStandby( string applicationId)
		{
			throw new global::System.NotImplementedException("The member BackgroundAccessStatus BackgroundExecutionManager.GetAccessStatusForModernStandby(string applicationId) is not implemented. For more information, visit https://aka.platform.uno/notimplemented?m=BackgroundAccessStatus%20BackgroundExecutionManager.GetAccessStatusForModernStandby%28string%20applicationId%29");
		}
		#endif
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public static global::Windows.Foundation.IAsyncOperation<bool> RequestAccessKindAsync( global::Windows.ApplicationModel.Background.BackgroundAccessRequestKind requestedAccess,  string reason)
		{
			throw new global::System.NotImplementedException("The member IAsyncOperation<bool> BackgroundExecutionManager.RequestAccessKindAsync(BackgroundAccessRequestKind requestedAccess, string reason) is not implemented. For more information, visit https://aka.platform.uno/notimplemented?m=IAsyncOperation%3Cbool%3E%20BackgroundExecutionManager.RequestAccessKindAsync%28BackgroundAccessRequestKind%20requestedAccess%2C%20string%20reason%29");
		}
		#endif
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public static global::Windows.Foundation.IAsyncOperation<global::Windows.ApplicationModel.Background.BackgroundAccessStatus> RequestAccessAsync()
		{
			throw new global::System.NotImplementedException("The member IAsyncOperation<BackgroundAccessStatus> BackgroundExecutionManager.RequestAccessAsync() is not implemented. For more information, visit https://aka.platform.uno/notimplemented?m=IAsyncOperation%3CBackgroundAccessStatus%3E%20BackgroundExecutionManager.RequestAccessAsync%28%29");
		}
		#endif
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public static global::Windows.Foundation.IAsyncOperation<global::Windows.ApplicationModel.Background.BackgroundAccessStatus> RequestAccessAsync( string applicationId)
		{
			throw new global::System.NotImplementedException("The member IAsyncOperation<BackgroundAccessStatus> BackgroundExecutionManager.RequestAccessAsync(string applicationId) is not implemented. For more information, visit https://aka.platform.uno/notimplemented?m=IAsyncOperation%3CBackgroundAccessStatus%3E%20BackgroundExecutionManager.RequestAccessAsync%28string%20applicationId%29");
		}
		#endif
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public static void RemoveAccess()
		{
			global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.ApplicationModel.Background.BackgroundExecutionManager", "void BackgroundExecutionManager.RemoveAccess()");
		}
		#endif
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public static void RemoveAccess( string applicationId)
		{
			global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.ApplicationModel.Background.BackgroundExecutionManager", "void BackgroundExecutionManager.RemoveAccess(string applicationId)");
		}
		#endif
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public static global::Windows.ApplicationModel.Background.BackgroundAccessStatus GetAccessStatus()
		{
			throw new global::System.NotImplementedException("The member BackgroundAccessStatus BackgroundExecutionManager.GetAccessStatus() is not implemented. For more information, visit https://aka.platform.uno/notimplemented?m=BackgroundAccessStatus%20BackgroundExecutionManager.GetAccessStatus%28%29");
		}
		#endif
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public static global::Windows.ApplicationModel.Background.BackgroundAccessStatus GetAccessStatus( string applicationId)
		{
			throw new global::System.NotImplementedException("The member BackgroundAccessStatus BackgroundExecutionManager.GetAccessStatus(string applicationId) is not implemented. For more information, visit https://aka.platform.uno/notimplemented?m=BackgroundAccessStatus%20BackgroundExecutionManager.GetAccessStatus%28string%20applicationId%29");
		}
		#endif
	}
}
