#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Windows.ApplicationModel.Store.Preview
{
	#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
	[global::Uno.NotImplemented]
	#endif
	public  partial class StorePreviewPurchaseResults 
	{
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  global::Windows.ApplicationModel.Store.Preview.StorePreviewProductPurchaseStatus ProductPurchaseStatus
		{
			get
			{
				throw new global::System.NotImplementedException("The member StorePreviewProductPurchaseStatus StorePreviewPurchaseResults.ProductPurchaseStatus is not implemented. For more information, visit https://aka.platform.uno/notimplemented?m=StorePreviewProductPurchaseStatus%20StorePreviewPurchaseResults.ProductPurchaseStatus");
			}
		}
		#endif
		// Forced skipping of method Windows.ApplicationModel.Store.Preview.StorePreviewPurchaseResults.ProductPurchaseStatus.get
	}
}
