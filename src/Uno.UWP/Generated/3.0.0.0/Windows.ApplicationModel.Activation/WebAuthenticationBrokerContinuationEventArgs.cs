#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Windows.ApplicationModel.Activation
{
	#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
	[global::Uno.NotImplemented]
	#endif
	public  partial class WebAuthenticationBrokerContinuationEventArgs : global::Windows.ApplicationModel.Activation.IWebAuthenticationBrokerContinuationEventArgs,global::Windows.ApplicationModel.Activation.IContinuationActivatedEventArgs,global::Windows.ApplicationModel.Activation.IActivatedEventArgs
	{
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  global::Windows.ApplicationModel.Activation.ActivationKind Kind
		{
			get
			{
				throw new global::System.NotImplementedException("The member ActivationKind WebAuthenticationBrokerContinuationEventArgs.Kind is not implemented. For more information, visit https://aka.platform.uno/notimplemented?m=ActivationKind%20WebAuthenticationBrokerContinuationEventArgs.Kind");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  global::Windows.ApplicationModel.Activation.ApplicationExecutionState PreviousExecutionState
		{
			get
			{
				throw new global::System.NotImplementedException("The member ApplicationExecutionState WebAuthenticationBrokerContinuationEventArgs.PreviousExecutionState is not implemented. For more information, visit https://aka.platform.uno/notimplemented?m=ApplicationExecutionState%20WebAuthenticationBrokerContinuationEventArgs.PreviousExecutionState");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  global::Windows.ApplicationModel.Activation.SplashScreen SplashScreen
		{
			get
			{
				throw new global::System.NotImplementedException("The member SplashScreen WebAuthenticationBrokerContinuationEventArgs.SplashScreen is not implemented. For more information, visit https://aka.platform.uno/notimplemented?m=SplashScreen%20WebAuthenticationBrokerContinuationEventArgs.SplashScreen");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  global::Windows.Foundation.Collections.ValueSet ContinuationData
		{
			get
			{
				throw new global::System.NotImplementedException("The member ValueSet WebAuthenticationBrokerContinuationEventArgs.ContinuationData is not implemented. For more information, visit https://aka.platform.uno/notimplemented?m=ValueSet%20WebAuthenticationBrokerContinuationEventArgs.ContinuationData");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  global::Windows.Security.Authentication.Web.WebAuthenticationResult WebAuthenticationResult
		{
			get
			{
				throw new global::System.NotImplementedException("The member WebAuthenticationResult WebAuthenticationBrokerContinuationEventArgs.WebAuthenticationResult is not implemented. For more information, visit https://aka.platform.uno/notimplemented?m=WebAuthenticationResult%20WebAuthenticationBrokerContinuationEventArgs.WebAuthenticationResult");
			}
		}
		#endif
		// Forced skipping of method Windows.ApplicationModel.Activation.WebAuthenticationBrokerContinuationEventArgs.WebAuthenticationResult.get
		// Forced skipping of method Windows.ApplicationModel.Activation.WebAuthenticationBrokerContinuationEventArgs.ContinuationData.get
		// Forced skipping of method Windows.ApplicationModel.Activation.WebAuthenticationBrokerContinuationEventArgs.Kind.get
		// Forced skipping of method Windows.ApplicationModel.Activation.WebAuthenticationBrokerContinuationEventArgs.PreviousExecutionState.get
		// Forced skipping of method Windows.ApplicationModel.Activation.WebAuthenticationBrokerContinuationEventArgs.SplashScreen.get
		// Processing: Windows.ApplicationModel.Activation.IWebAuthenticationBrokerContinuationEventArgs
		// Processing: Windows.ApplicationModel.Activation.IContinuationActivatedEventArgs
		// Processing: Windows.ApplicationModel.Activation.IActivatedEventArgs
	}
}
