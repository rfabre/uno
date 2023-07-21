#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Windows.Storage.FileProperties
{
	#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
	[global::Uno.NotImplemented]
	#endif
	public static partial class GeotagHelper 
	{
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public static global::Windows.Foundation.IAsyncOperation<global::Windows.Devices.Geolocation.Geopoint> GetGeotagAsync( global::Windows.Storage.IStorageFile file)
		{
			throw new global::System.NotImplementedException("The member IAsyncOperation<Geopoint> GeotagHelper.GetGeotagAsync(IStorageFile file) is not implemented. For more information, visit https://aka.platform.uno/notimplemented?m=IAsyncOperation%3CGeopoint%3E%20GeotagHelper.GetGeotagAsync%28IStorageFile%20file%29");
		}
		#endif
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public static global::Windows.Foundation.IAsyncAction SetGeotagFromGeolocatorAsync( global::Windows.Storage.IStorageFile file,  global::Windows.Devices.Geolocation.Geolocator geolocator)
		{
			throw new global::System.NotImplementedException("The member IAsyncAction GeotagHelper.SetGeotagFromGeolocatorAsync(IStorageFile file, Geolocator geolocator) is not implemented. For more information, visit https://aka.platform.uno/notimplemented?m=IAsyncAction%20GeotagHelper.SetGeotagFromGeolocatorAsync%28IStorageFile%20file%2C%20Geolocator%20geolocator%29");
		}
		#endif
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public static global::Windows.Foundation.IAsyncAction SetGeotagAsync( global::Windows.Storage.IStorageFile file,  global::Windows.Devices.Geolocation.Geopoint geopoint)
		{
			throw new global::System.NotImplementedException("The member IAsyncAction GeotagHelper.SetGeotagAsync(IStorageFile file, Geopoint geopoint) is not implemented. For more information, visit https://aka.platform.uno/notimplemented?m=IAsyncAction%20GeotagHelper.SetGeotagAsync%28IStorageFile%20file%2C%20Geopoint%20geopoint%29");
		}
		#endif
	}
}
