#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Windows.Devices.Bluetooth.GenericAttributeProfile
{
	#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
	[global::Uno.NotImplemented]
	#endif
	public  partial class GattLocalDescriptorResult 
	{
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  global::Windows.Devices.Bluetooth.GenericAttributeProfile.GattLocalDescriptor Descriptor
		{
			get
			{
				throw new global::System.NotImplementedException("The member GattLocalDescriptor GattLocalDescriptorResult.Descriptor is not implemented. For more information, visit https://aka.platform.uno/notimplemented?m=GattLocalDescriptor%20GattLocalDescriptorResult.Descriptor");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  global::Windows.Devices.Bluetooth.BluetoothError Error
		{
			get
			{
				throw new global::System.NotImplementedException("The member BluetoothError GattLocalDescriptorResult.Error is not implemented. For more information, visit https://aka.platform.uno/notimplemented?m=BluetoothError%20GattLocalDescriptorResult.Error");
			}
		}
		#endif
		// Forced skipping of method Windows.Devices.Bluetooth.GenericAttributeProfile.GattLocalDescriptorResult.Descriptor.get
		// Forced skipping of method Windows.Devices.Bluetooth.GenericAttributeProfile.GattLocalDescriptorResult.Error.get
	}
}
