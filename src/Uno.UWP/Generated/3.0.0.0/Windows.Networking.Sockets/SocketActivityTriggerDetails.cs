#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Windows.Networking.Sockets
{
	#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
	[global::Uno.NotImplemented]
	#endif
	public  partial class SocketActivityTriggerDetails 
	{
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  global::Windows.Networking.Sockets.SocketActivityTriggerReason Reason
		{
			get
			{
				throw new global::System.NotImplementedException("The member SocketActivityTriggerReason SocketActivityTriggerDetails.Reason is not implemented. For more information, visit https://aka.platform.uno/notimplemented?m=SocketActivityTriggerReason%20SocketActivityTriggerDetails.Reason");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  global::Windows.Networking.Sockets.SocketActivityInformation SocketInformation
		{
			get
			{
				throw new global::System.NotImplementedException("The member SocketActivityInformation SocketActivityTriggerDetails.SocketInformation is not implemented. For more information, visit https://aka.platform.uno/notimplemented?m=SocketActivityInformation%20SocketActivityTriggerDetails.SocketInformation");
			}
		}
		#endif
		// Forced skipping of method Windows.Networking.Sockets.SocketActivityTriggerDetails.Reason.get
		// Forced skipping of method Windows.Networking.Sockets.SocketActivityTriggerDetails.SocketInformation.get
	}
}
