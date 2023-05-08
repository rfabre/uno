---
uid: Uno.GettingStarted.UsingWizard.Features
---

- **Toolkit**  
    Installs the [Uno.Toolkit](https://github.com/unoplatform/uno.toolkit.ui) package in the project, which adds a set of custom controls, behaviors, extensions, and other utilities to Uno Platform projects that are not offered out-of-the-box by WinUI.  
    This includes [`Card`](https://github.com/unoplatform/uno.toolkit.ui/blob/main/src/Uno.Toolkit.UI/Controls/Card/Card.cs), [`TabBar`](https://github.com/unoplatform/uno.toolkit.ui/blob/main/src/Uno.Toolkit.UI/Controls/TabBar/TabBar.cs), [`NavigationBar`](https://github.com/unoplatform/uno.toolkit.ui/blob/main/src/Uno.Toolkit.UI/Controls/NavigationBar/NavigationBar.cs) and others.
    
    > [!TIP]
    > The Uno Toolkit is demonstrated as a live web app [here](https://gallery.platform.uno/). It is also available as an [iOS](https://apps.apple.com/us/app/uno-gallery/id1380984680) or [Android](https://play.google.com/store/apps/details?id=com.nventive.uno.ui.demo) app.  
    > The Gallery app is open-source and is [available on GitHub](https://github.com/unoplatform/uno.gallery).  

- **PWA Manifest**  
    Includes a PWA ([Progressive Web Apps](https://learn.microsoft.com/en-us/microsoft-edge/progressive-web-apps-chromium)) manifest that enables easy installation of the WASM web-target as an app in the running device.

    > [!NOTE]
    > As this is a WASM feature it will be disabled if WASM is not selected as one of the output target platforms.

- **Visual Studio Code debugging**  
    Enables Uno Platform debugging in Visual Studio Code.

![Features tab in the wizard](assets/features.jpg)
