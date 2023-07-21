#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Windows.Devices.Sensors
{
	#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
	[global::Uno.NotImplemented]
	#endif
	public  partial class OrientationSensor 
	{
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  uint ReportInterval
		{
			get
			{
				throw new global::System.NotImplementedException("The member uint OrientationSensor.ReportInterval is not implemented. For more information, visit https://aka.platform.uno/notimplemented?m=uint%20OrientationSensor.ReportInterval");
			}
			set
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.Devices.Sensors.OrientationSensor", "uint OrientationSensor.ReportInterval");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  uint MinimumReportInterval
		{
			get
			{
				throw new global::System.NotImplementedException("The member uint OrientationSensor.MinimumReportInterval is not implemented. For more information, visit https://aka.platform.uno/notimplemented?m=uint%20OrientationSensor.MinimumReportInterval");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  global::Windows.Graphics.Display.DisplayOrientations ReadingTransform
		{
			get
			{
				throw new global::System.NotImplementedException("The member DisplayOrientations OrientationSensor.ReadingTransform is not implemented. For more information, visit https://aka.platform.uno/notimplemented?m=DisplayOrientations%20OrientationSensor.ReadingTransform");
			}
			set
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.Devices.Sensors.OrientationSensor", "DisplayOrientations OrientationSensor.ReadingTransform");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  global::Windows.Devices.Sensors.SensorReadingType ReadingType
		{
			get
			{
				throw new global::System.NotImplementedException("The member SensorReadingType OrientationSensor.ReadingType is not implemented. For more information, visit https://aka.platform.uno/notimplemented?m=SensorReadingType%20OrientationSensor.ReadingType");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  uint ReportLatency
		{
			get
			{
				throw new global::System.NotImplementedException("The member uint OrientationSensor.ReportLatency is not implemented. For more information, visit https://aka.platform.uno/notimplemented?m=uint%20OrientationSensor.ReportLatency");
			}
			set
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.Devices.Sensors.OrientationSensor", "uint OrientationSensor.ReportLatency");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  uint MaxBatchSize
		{
			get
			{
				throw new global::System.NotImplementedException("The member uint OrientationSensor.MaxBatchSize is not implemented. For more information, visit https://aka.platform.uno/notimplemented?m=uint%20OrientationSensor.MaxBatchSize");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  string DeviceId
		{
			get
			{
				throw new global::System.NotImplementedException("The member string OrientationSensor.DeviceId is not implemented. For more information, visit https://aka.platform.uno/notimplemented?m=string%20OrientationSensor.DeviceId");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  global::Windows.Devices.Sensors.OrientationSensorReading GetCurrentReading()
		{
			throw new global::System.NotImplementedException("The member OrientationSensorReading OrientationSensor.GetCurrentReading() is not implemented. For more information, visit https://aka.platform.uno/notimplemented?m=OrientationSensorReading%20OrientationSensor.GetCurrentReading%28%29");
		}
		#endif
		// Forced skipping of method Windows.Devices.Sensors.OrientationSensor.MinimumReportInterval.get
		// Forced skipping of method Windows.Devices.Sensors.OrientationSensor.ReportInterval.set
		// Forced skipping of method Windows.Devices.Sensors.OrientationSensor.ReportInterval.get
		// Forced skipping of method Windows.Devices.Sensors.OrientationSensor.ReadingChanged.add
		// Forced skipping of method Windows.Devices.Sensors.OrientationSensor.ReadingChanged.remove
		// Forced skipping of method Windows.Devices.Sensors.OrientationSensor.DeviceId.get
		// Forced skipping of method Windows.Devices.Sensors.OrientationSensor.ReadingTransform.set
		// Forced skipping of method Windows.Devices.Sensors.OrientationSensor.ReadingTransform.get
		// Forced skipping of method Windows.Devices.Sensors.OrientationSensor.ReadingType.get
		// Forced skipping of method Windows.Devices.Sensors.OrientationSensor.ReportLatency.set
		// Forced skipping of method Windows.Devices.Sensors.OrientationSensor.ReportLatency.get
		// Forced skipping of method Windows.Devices.Sensors.OrientationSensor.MaxBatchSize.get
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public static string GetDeviceSelector( global::Windows.Devices.Sensors.SensorReadingType readingType)
		{
			throw new global::System.NotImplementedException("The member string OrientationSensor.GetDeviceSelector(SensorReadingType readingType) is not implemented. For more information, visit https://aka.platform.uno/notimplemented?m=string%20OrientationSensor.GetDeviceSelector%28SensorReadingType%20readingType%29");
		}
		#endif
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public static string GetDeviceSelector( global::Windows.Devices.Sensors.SensorReadingType readingType,  global::Windows.Devices.Sensors.SensorOptimizationGoal optimizationGoal)
		{
			throw new global::System.NotImplementedException("The member string OrientationSensor.GetDeviceSelector(SensorReadingType readingType, SensorOptimizationGoal optimizationGoal) is not implemented. For more information, visit https://aka.platform.uno/notimplemented?m=string%20OrientationSensor.GetDeviceSelector%28SensorReadingType%20readingType%2C%20SensorOptimizationGoal%20optimizationGoal%29");
		}
		#endif
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public static global::Windows.Foundation.IAsyncOperation<global::Windows.Devices.Sensors.OrientationSensor> FromIdAsync( string deviceId)
		{
			throw new global::System.NotImplementedException("The member IAsyncOperation<OrientationSensor> OrientationSensor.FromIdAsync(string deviceId) is not implemented. For more information, visit https://aka.platform.uno/notimplemented?m=IAsyncOperation%3COrientationSensor%3E%20OrientationSensor.FromIdAsync%28string%20deviceId%29");
		}
		#endif
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public static global::Windows.Devices.Sensors.OrientationSensor GetDefault( global::Windows.Devices.Sensors.SensorReadingType sensorReadingtype)
		{
			throw new global::System.NotImplementedException("The member OrientationSensor OrientationSensor.GetDefault(SensorReadingType sensorReadingtype) is not implemented. For more information, visit https://aka.platform.uno/notimplemented?m=OrientationSensor%20OrientationSensor.GetDefault%28SensorReadingType%20sensorReadingtype%29");
		}
		#endif
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public static global::Windows.Devices.Sensors.OrientationSensor GetDefault( global::Windows.Devices.Sensors.SensorReadingType sensorReadingType,  global::Windows.Devices.Sensors.SensorOptimizationGoal optimizationGoal)
		{
			throw new global::System.NotImplementedException("The member OrientationSensor OrientationSensor.GetDefault(SensorReadingType sensorReadingType, SensorOptimizationGoal optimizationGoal) is not implemented. For more information, visit https://aka.platform.uno/notimplemented?m=OrientationSensor%20OrientationSensor.GetDefault%28SensorReadingType%20sensorReadingType%2C%20SensorOptimizationGoal%20optimizationGoal%29");
		}
		#endif
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public static global::Windows.Devices.Sensors.OrientationSensor GetDefaultForRelativeReadings()
		{
			throw new global::System.NotImplementedException("The member OrientationSensor OrientationSensor.GetDefaultForRelativeReadings() is not implemented. For more information, visit https://aka.platform.uno/notimplemented?m=OrientationSensor%20OrientationSensor.GetDefaultForRelativeReadings%28%29");
		}
		#endif
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public static global::Windows.Devices.Sensors.OrientationSensor GetDefault()
		{
			throw new global::System.NotImplementedException("The member OrientationSensor OrientationSensor.GetDefault() is not implemented. For more information, visit https://aka.platform.uno/notimplemented?m=OrientationSensor%20OrientationSensor.GetDefault%28%29");
		}
		#endif
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  event global::Windows.Foundation.TypedEventHandler<global::Windows.Devices.Sensors.OrientationSensor, global::Windows.Devices.Sensors.OrientationSensorReadingChangedEventArgs> ReadingChanged
		{
			[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
			add
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.Devices.Sensors.OrientationSensor", "event TypedEventHandler<OrientationSensor, OrientationSensorReadingChangedEventArgs> OrientationSensor.ReadingChanged");
			}
			[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
			remove
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.Devices.Sensors.OrientationSensor", "event TypedEventHandler<OrientationSensor, OrientationSensorReadingChangedEventArgs> OrientationSensor.ReadingChanged");
			}
		}
		#endif
	}
}
