#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Windows.UI.Xaml.Automation.Peers
{
	#if false || false || false || false || false || false || false
	[global::Uno.NotImplemented]
	#endif
	public  partial class ListViewBaseAutomationPeer : global::Windows.UI.Xaml.Automation.Peers.SelectorAutomationPeer,global::Windows.UI.Xaml.Automation.Provider.IDropTargetProvider
	{
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  string DropEffect
		{
			get
			{
				throw new global::System.NotImplementedException("The member string ListViewBaseAutomationPeer.DropEffect is not implemented. For more information, visit https://aka.platform.uno/notimplemented?m=string%20ListViewBaseAutomationPeer.DropEffect");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  string[] DropEffects
		{
			get
			{
				throw new global::System.NotImplementedException("The member string[] ListViewBaseAutomationPeer.DropEffects is not implemented. For more information, visit https://aka.platform.uno/notimplemented?m=string%5B%5D%20ListViewBaseAutomationPeer.DropEffects");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public ListViewBaseAutomationPeer( global::Windows.UI.Xaml.Controls.ListViewBase owner) : base(owner)
		{
			global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.UI.Xaml.Automation.Peers.ListViewBaseAutomationPeer", "ListViewBaseAutomationPeer.ListViewBaseAutomationPeer(ListViewBase owner)");
		}
		#endif
		// Forced skipping of method Windows.UI.Xaml.Automation.Peers.ListViewBaseAutomationPeer.ListViewBaseAutomationPeer(Windows.UI.Xaml.Controls.ListViewBase)
		// Forced skipping of method Windows.UI.Xaml.Automation.Peers.ListViewBaseAutomationPeer.DropEffect.get
		// Forced skipping of method Windows.UI.Xaml.Automation.Peers.ListViewBaseAutomationPeer.DropEffects.get
		// Processing: Windows.UI.Xaml.Automation.Provider.IDropTargetProvider
	}
}
