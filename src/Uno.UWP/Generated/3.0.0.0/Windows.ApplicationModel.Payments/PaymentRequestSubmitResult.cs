#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Windows.ApplicationModel.Payments
{
	#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
	[global::Uno.NotImplemented]
	#endif
	public  partial class PaymentRequestSubmitResult 
	{
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  global::Windows.ApplicationModel.Payments.PaymentResponse Response
		{
			get
			{
				throw new global::System.NotImplementedException("The member PaymentResponse PaymentRequestSubmitResult.Response is not implemented. For more information, visit https://aka.platform.uno/notimplemented?m=PaymentResponse%20PaymentRequestSubmitResult.Response");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  global::Windows.ApplicationModel.Payments.PaymentRequestStatus Status
		{
			get
			{
				throw new global::System.NotImplementedException("The member PaymentRequestStatus PaymentRequestSubmitResult.Status is not implemented. For more information, visit https://aka.platform.uno/notimplemented?m=PaymentRequestStatus%20PaymentRequestSubmitResult.Status");
			}
		}
		#endif
		// Forced skipping of method Windows.ApplicationModel.Payments.PaymentRequestSubmitResult.Status.get
		// Forced skipping of method Windows.ApplicationModel.Payments.PaymentRequestSubmitResult.Response.get
	}
}
