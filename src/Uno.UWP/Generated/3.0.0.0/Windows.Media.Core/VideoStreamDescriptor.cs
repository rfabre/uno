#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Windows.Media.Core
{
	#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
	[global::Uno.NotImplemented]
	#endif
	public  partial class VideoStreamDescriptor : global::Windows.Media.Core.IMediaStreamDescriptor,global::Windows.Media.Core.IMediaStreamDescriptor2
	{
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  string Name
		{
			get
			{
				throw new global::System.NotImplementedException("The member string VideoStreamDescriptor.Name is not implemented. For more information, visit https://aka.platform.uno/notimplemented?m=string%20VideoStreamDescriptor.Name");
			}
			set
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.Media.Core.VideoStreamDescriptor", "string VideoStreamDescriptor.Name");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  string Language
		{
			get
			{
				throw new global::System.NotImplementedException("The member string VideoStreamDescriptor.Language is not implemented. For more information, visit https://aka.platform.uno/notimplemented?m=string%20VideoStreamDescriptor.Language");
			}
			set
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.Media.Core.VideoStreamDescriptor", "string VideoStreamDescriptor.Language");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  bool IsSelected
		{
			get
			{
				throw new global::System.NotImplementedException("The member bool VideoStreamDescriptor.IsSelected is not implemented. For more information, visit https://aka.platform.uno/notimplemented?m=bool%20VideoStreamDescriptor.IsSelected");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  string Label
		{
			get
			{
				throw new global::System.NotImplementedException("The member string VideoStreamDescriptor.Label is not implemented. For more information, visit https://aka.platform.uno/notimplemented?m=string%20VideoStreamDescriptor.Label");
			}
			set
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.Media.Core.VideoStreamDescriptor", "string VideoStreamDescriptor.Label");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  global::Windows.Media.MediaProperties.VideoEncodingProperties EncodingProperties
		{
			get
			{
				throw new global::System.NotImplementedException("The member VideoEncodingProperties VideoStreamDescriptor.EncodingProperties is not implemented. For more information, visit https://aka.platform.uno/notimplemented?m=VideoEncodingProperties%20VideoStreamDescriptor.EncodingProperties");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public VideoStreamDescriptor( global::Windows.Media.MediaProperties.VideoEncodingProperties encodingProperties) 
		{
			global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.Media.Core.VideoStreamDescriptor", "VideoStreamDescriptor.VideoStreamDescriptor(VideoEncodingProperties encodingProperties)");
		}
		#endif
		// Forced skipping of method Windows.Media.Core.VideoStreamDescriptor.VideoStreamDescriptor(Windows.Media.MediaProperties.VideoEncodingProperties)
		// Forced skipping of method Windows.Media.Core.VideoStreamDescriptor.EncodingProperties.get
		// Forced skipping of method Windows.Media.Core.VideoStreamDescriptor.IsSelected.get
		// Forced skipping of method Windows.Media.Core.VideoStreamDescriptor.Name.set
		// Forced skipping of method Windows.Media.Core.VideoStreamDescriptor.Name.get
		// Forced skipping of method Windows.Media.Core.VideoStreamDescriptor.Language.set
		// Forced skipping of method Windows.Media.Core.VideoStreamDescriptor.Language.get
		// Forced skipping of method Windows.Media.Core.VideoStreamDescriptor.Label.set
		// Forced skipping of method Windows.Media.Core.VideoStreamDescriptor.Label.get
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  global::Windows.Media.Core.VideoStreamDescriptor Copy()
		{
			throw new global::System.NotImplementedException("The member VideoStreamDescriptor VideoStreamDescriptor.Copy() is not implemented. For more information, visit https://aka.platform.uno/notimplemented?m=VideoStreamDescriptor%20VideoStreamDescriptor.Copy%28%29");
		}
		#endif
		// Processing: Windows.Media.Core.IMediaStreamDescriptor
		// Processing: Windows.Media.Core.IMediaStreamDescriptor2
	}
}
