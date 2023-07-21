#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Windows.ApplicationModel.Contacts
{
	#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
	[global::Uno.NotImplemented]
	#endif
	public  partial class ContactAnnotationStore 
	{
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  global::Windows.Foundation.IAsyncOperation<global::System.Collections.Generic.IReadOnlyList<string>> FindContactIdsByEmailAsync( string emailAddress)
		{
			throw new global::System.NotImplementedException("The member IAsyncOperation<IReadOnlyList<string>> ContactAnnotationStore.FindContactIdsByEmailAsync(string emailAddress) is not implemented. For more information, visit https://aka.platform.uno/notimplemented?m=IAsyncOperation%3CIReadOnlyList%3Cstring%3E%3E%20ContactAnnotationStore.FindContactIdsByEmailAsync%28string%20emailAddress%29");
		}
		#endif
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  global::Windows.Foundation.IAsyncOperation<global::System.Collections.Generic.IReadOnlyList<string>> FindContactIdsByPhoneNumberAsync( string phoneNumber)
		{
			throw new global::System.NotImplementedException("The member IAsyncOperation<IReadOnlyList<string>> ContactAnnotationStore.FindContactIdsByPhoneNumberAsync(string phoneNumber) is not implemented. For more information, visit https://aka.platform.uno/notimplemented?m=IAsyncOperation%3CIReadOnlyList%3Cstring%3E%3E%20ContactAnnotationStore.FindContactIdsByPhoneNumberAsync%28string%20phoneNumber%29");
		}
		#endif
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  global::Windows.Foundation.IAsyncOperation<global::System.Collections.Generic.IReadOnlyList<global::Windows.ApplicationModel.Contacts.ContactAnnotation>> FindAnnotationsForContactAsync( global::Windows.ApplicationModel.Contacts.Contact contact)
		{
			throw new global::System.NotImplementedException("The member IAsyncOperation<IReadOnlyList<ContactAnnotation>> ContactAnnotationStore.FindAnnotationsForContactAsync(Contact contact) is not implemented. For more information, visit https://aka.platform.uno/notimplemented?m=IAsyncOperation%3CIReadOnlyList%3CContactAnnotation%3E%3E%20ContactAnnotationStore.FindAnnotationsForContactAsync%28Contact%20contact%29");
		}
		#endif
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  global::Windows.Foundation.IAsyncAction DisableAnnotationAsync( global::Windows.ApplicationModel.Contacts.ContactAnnotation annotation)
		{
			throw new global::System.NotImplementedException("The member IAsyncAction ContactAnnotationStore.DisableAnnotationAsync(ContactAnnotation annotation) is not implemented. For more information, visit https://aka.platform.uno/notimplemented?m=IAsyncAction%20ContactAnnotationStore.DisableAnnotationAsync%28ContactAnnotation%20annotation%29");
		}
		#endif
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  global::Windows.Foundation.IAsyncOperation<global::Windows.ApplicationModel.Contacts.ContactAnnotationList> CreateAnnotationListAsync()
		{
			throw new global::System.NotImplementedException("The member IAsyncOperation<ContactAnnotationList> ContactAnnotationStore.CreateAnnotationListAsync() is not implemented. For more information, visit https://aka.platform.uno/notimplemented?m=IAsyncOperation%3CContactAnnotationList%3E%20ContactAnnotationStore.CreateAnnotationListAsync%28%29");
		}
		#endif
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  global::Windows.Foundation.IAsyncOperation<global::Windows.ApplicationModel.Contacts.ContactAnnotationList> CreateAnnotationListAsync( string userDataAccountId)
		{
			throw new global::System.NotImplementedException("The member IAsyncOperation<ContactAnnotationList> ContactAnnotationStore.CreateAnnotationListAsync(string userDataAccountId) is not implemented. For more information, visit https://aka.platform.uno/notimplemented?m=IAsyncOperation%3CContactAnnotationList%3E%20ContactAnnotationStore.CreateAnnotationListAsync%28string%20userDataAccountId%29");
		}
		#endif
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  global::Windows.Foundation.IAsyncOperation<global::Windows.ApplicationModel.Contacts.ContactAnnotationList> GetAnnotationListAsync( string annotationListId)
		{
			throw new global::System.NotImplementedException("The member IAsyncOperation<ContactAnnotationList> ContactAnnotationStore.GetAnnotationListAsync(string annotationListId) is not implemented. For more information, visit https://aka.platform.uno/notimplemented?m=IAsyncOperation%3CContactAnnotationList%3E%20ContactAnnotationStore.GetAnnotationListAsync%28string%20annotationListId%29");
		}
		#endif
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  global::Windows.Foundation.IAsyncOperation<global::System.Collections.Generic.IReadOnlyList<global::Windows.ApplicationModel.Contacts.ContactAnnotationList>> FindAnnotationListsAsync()
		{
			throw new global::System.NotImplementedException("The member IAsyncOperation<IReadOnlyList<ContactAnnotationList>> ContactAnnotationStore.FindAnnotationListsAsync() is not implemented. For more information, visit https://aka.platform.uno/notimplemented?m=IAsyncOperation%3CIReadOnlyList%3CContactAnnotationList%3E%3E%20ContactAnnotationStore.FindAnnotationListsAsync%28%29");
		}
		#endif
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  global::Windows.Foundation.IAsyncOperation<global::System.Collections.Generic.IReadOnlyList<global::Windows.ApplicationModel.Contacts.ContactAnnotation>> FindAnnotationsForContactListAsync( string contactListId)
		{
			throw new global::System.NotImplementedException("The member IAsyncOperation<IReadOnlyList<ContactAnnotation>> ContactAnnotationStore.FindAnnotationsForContactListAsync(string contactListId) is not implemented. For more information, visit https://aka.platform.uno/notimplemented?m=IAsyncOperation%3CIReadOnlyList%3CContactAnnotation%3E%3E%20ContactAnnotationStore.FindAnnotationsForContactListAsync%28string%20contactListId%29");
		}
		#endif
	}
}
