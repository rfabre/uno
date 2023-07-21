#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Windows.System.Diagnostics
{
	#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
	[global::Uno.NotImplemented]
	#endif
	public  partial class ProcessCpuUsageReport 
	{
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  global::System.TimeSpan KernelTime
		{
			get
			{
				throw new global::System.NotImplementedException("The member TimeSpan ProcessCpuUsageReport.KernelTime is not implemented. For more information, visit https://aka.platform.uno/notimplemented?m=TimeSpan%20ProcessCpuUsageReport.KernelTime");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  global::System.TimeSpan UserTime
		{
			get
			{
				throw new global::System.NotImplementedException("The member TimeSpan ProcessCpuUsageReport.UserTime is not implemented. For more information, visit https://aka.platform.uno/notimplemented?m=TimeSpan%20ProcessCpuUsageReport.UserTime");
			}
		}
		#endif
		// Forced skipping of method Windows.System.Diagnostics.ProcessCpuUsageReport.KernelTime.get
		// Forced skipping of method Windows.System.Diagnostics.ProcessCpuUsageReport.UserTime.get
	}
}
