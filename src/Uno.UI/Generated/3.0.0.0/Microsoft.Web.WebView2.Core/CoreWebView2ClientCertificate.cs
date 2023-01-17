#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Microsoft.Web.WebView2.Core
{
	#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
	[global::Uno.NotImplemented]
	#endif
	public  partial class CoreWebView2ClientCertificate 
	{
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "NET461", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  string DerEncodedSerialNumber
		{
			get
			{
				throw new global::System.NotImplementedException("The member string CoreWebView2ClientCertificate.DerEncodedSerialNumber is not implemented in Uno.");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "NET461", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  string DisplayName
		{
			get
			{
				throw new global::System.NotImplementedException("The member string CoreWebView2ClientCertificate.DisplayName is not implemented in Uno.");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "NET461", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  string Issuer
		{
			get
			{
				throw new global::System.NotImplementedException("The member string CoreWebView2ClientCertificate.Issuer is not implemented in Uno.");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "NET461", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  global::Microsoft.Web.WebView2.Core.CoreWebView2ClientCertificateKind Kind
		{
			get
			{
				throw new global::System.NotImplementedException("The member CoreWebView2ClientCertificateKind CoreWebView2ClientCertificate.Kind is not implemented in Uno.");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "NET461", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  global::System.Collections.Generic.IReadOnlyList<string> PemEncodedIssuerCertificateChain
		{
			get
			{
				throw new global::System.NotImplementedException("The member IReadOnlyList<string> CoreWebView2ClientCertificate.PemEncodedIssuerCertificateChain is not implemented in Uno.");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "NET461", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  string Subject
		{
			get
			{
				throw new global::System.NotImplementedException("The member string CoreWebView2ClientCertificate.Subject is not implemented in Uno.");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "NET461", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  double ValidFrom
		{
			get
			{
				throw new global::System.NotImplementedException("The member double CoreWebView2ClientCertificate.ValidFrom is not implemented in Uno.");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "NET461", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  double ValidTo
		{
			get
			{
				throw new global::System.NotImplementedException("The member double CoreWebView2ClientCertificate.ValidTo is not implemented in Uno.");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "NET461", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  global::Windows.Security.Cryptography.Certificates.Certificate ToCertificate()
		{
			throw new global::System.NotImplementedException("The member Certificate CoreWebView2ClientCertificate.ToCertificate() is not implemented in Uno.");
		}
		#endif
		// Forced skipping of method Microsoft.Web.WebView2.Core.CoreWebView2ClientCertificate.Subject.get
		// Forced skipping of method Microsoft.Web.WebView2.Core.CoreWebView2ClientCertificate.Issuer.get
		// Forced skipping of method Microsoft.Web.WebView2.Core.CoreWebView2ClientCertificate.ValidFrom.get
		// Forced skipping of method Microsoft.Web.WebView2.Core.CoreWebView2ClientCertificate.ValidTo.get
		// Forced skipping of method Microsoft.Web.WebView2.Core.CoreWebView2ClientCertificate.DerEncodedSerialNumber.get
		// Forced skipping of method Microsoft.Web.WebView2.Core.CoreWebView2ClientCertificate.DisplayName.get
		// Forced skipping of method Microsoft.Web.WebView2.Core.CoreWebView2ClientCertificate.PemEncodedIssuerCertificateChain.get
		// Forced skipping of method Microsoft.Web.WebView2.Core.CoreWebView2ClientCertificate.Kind.get
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "NET461", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  string ToPemEncoding()
		{
			throw new global::System.NotImplementedException("The member string CoreWebView2ClientCertificate.ToPemEncoding() is not implemented in Uno.");
		}
		#endif
	}
}
