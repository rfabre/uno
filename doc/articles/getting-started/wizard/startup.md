---
uid: Uno.GettingStarted.UsingWizard.Startup
---

The main page of the wizard shows and the default template is selected.

![](assets/wizard-intro.jpg)

This is introductory page to the wizard and lets you choose between the blank or default template, and also enables you to customize that selection even further if you click *Customize*.

- **Blank**

    The *Blank* template generates a minimal Uno Platform app that targets the following platforms:

    - Windows
    - Android
    - iOS
    - macOS
    - GTK
    - WASM

    Click "Create" or hit <kbd>Enter</kbd> to accept the selected choice and generate the project, or select the Default template.

    This is the structure of the generated blank project:

    ![](assets/blank-project-structure.jpg)    

- **Default**

    The default Project also consists of the above platforms: Windows, Android, iOS, macOS, GTK, and WASM, however this template is preselected with additional features and pre-installed packages to help save even more saving you from typing redundant boilerplate code.
    This includes a backend ASP.NET Core server app which you can use to write your server API endpoints, and is also used to host the WASM app.  
    It also includes a project with Uno.UITest preinstalled. This package includes important UI testing features of which you can learn [here](xref:Uno.UITest.GetStarted).  

    In addition, it includes baked in support provided by Uno.Extensions. Uno Extensions extends [Microsoft.Extensions.*](https://learn.microsoft.com/en-us/dotnet/standard/runtime-libraries-overview#extensions-to-the-runtime-libraries) by making sure it runs smoothly on all platforms and adding additional features and utils.

    This template includes out-of-the-box support for many of Uno Platform flagship products, Extensions, and Toolkit:

    #### Configuration

    This extension provides a way to load application configuration data from and to various sources using the [Options Pattern](https://learn.microsoft.com/en-us/dotnet/core/extensions/options).
    Refer to the [Uno Configuration](xref:Overview.Configuration) documentation for more information.

    #### App Hosting

    Hosting keeps the central entry point of the app and encapsulates its core building blocks, such as [DI](#dependency-injection), [Logging](#logging), as well as controlling its state and shutdown.

    #### Dependency Injection

    Dependency Injection (DI) is an Inversion of Control (IoC) technique which enables consuming classes not to worry about the management or creation of their dependencies, and instead rely on a central service to provide it when needed, based how the provider was configured.      
    Uno Platform brings the power of [Microsoft Extensions Dependency Injection](https://learn.microsoft.com/en-us/dotnet/core/extensions/dependency-injection) to all OSs Uno Platform targets, and adds its additional functionality via its Uno.Extensions.DependencyInjection library, which you can learn more about [here](xref:Overview.DependencyInjection).

    #### Logging

    Logging is a crucial component in an app that enables the developer to emit log messages whenever an important action or execution is taken by the app. This then lets you trace back any errors or issues that may arise in the future.
    There are several Logging tools out there, with one of the most common of them being [Microosft.Extensions.Logging](https://learn.microsoft.com/en-us/dotnet/core/extensions/logging).  
    Uno Platform provides its Uno.Extensions.Logging to bring Logging to all platforms it supports.  
    The default template generates an app configured to write debug-level logging information to the Console, and set-up using Congiguration, Hosting, and DI.  
    Uno.Extensions.Logging is covered in more detail [here](xref:Overview.Logging).

    #### Navigation

    Navigation is an integral part of any app and for that, Uno Platform has developed a navigation system that is registered and served using DI and is fully integrated with the navigation specific UI controls out-there, such as `Frame`, `NavigationView`, and `TabBar`.  
    It is a region-based navigation. A Region is the abstraction of the view responsible for handling navigation. Regions are structured into a logical hierarchical representation that shadows the navigation-aware controls in the visual hierarchy. The hierarchy allows navigation requests to be propagated up to parent and down to child regions as required.  
    This library is also responsible for showing pop-ups, flyouts, dialogs, and other interactions with the user.  
    Learn more about Uno's Navigation library [here](xref:Overview.Navigation).

    #### HttpClient factory

    Uno.Extensions.Http allows for the registration of API endpoints as multiple typed HttpClient instances. In this centralized location for accessing web resources, the lifecycle of the corresponding HttpMessageHandler objects is managed. Added clients can optionally be configured to use the platform-native handler. Additional functionality is provided to clear cookies or log diagnostic messages in responses. This library uses Microsoft.Extensions.Http for any HTTP related work.
    For more documentation on HTTP requests, [read the documentation](xref:Overview.Http).

    Another related package installed with the default template is Refit. This is a port of the [Refit library](https://github.com/reactiveui/refit) that enables mapping REST APIs into .NET interfaces.
    Refer to the [documentation](xref:Overview.Http#refit) to learn how to use it in an Uno Platform app.

    #### Localization

    The Localization extension is responsible for managing globalization of your app.  
    This enables keeping all translations of your app in a single place and enables the user to easily switch the UI language.

    The generated app contains *resw* files which can be used to define the application strings. The defined languages are configured in *appsettings.json*. Follow [this link](Learn.Tutorials.Localization.HowToUseLocalization#3-update-the-ui-culture-with-localizationsettings) to learn how to switch the UI culture.

    ![](Assets/localization.jpg)
    
    The default settings comes with the following pre-set languages: English (*en*), Spanish (*es*), French (*fr*), and Potuguese - Brazil (*pt-BR*).

    Uno.Extensions.Localization expands [Microsoft.Extensions.Localization](https://learn.microsoft.com/en-us/dotnet/core/extensions/localization) to all OSs supported by Uno Platform.  
    Read the full Localization documentation [here](xref:Overview.Localization) or learn more about [Globalization](https://learn.microsoft.com/en-us/dotnet/core/extensions/globalization).    

    #### Serialization

    Serialization is the act of serializing data. The default serializer used with Uno.Extensions.Serialization is the new System.Text.Json, but you can easily configure it to use other serializers (such as XML etc.), or your custom ones.
    This subject is discussed in more detail [here](xref:Overview.Serialization).

    #### The MVUX pattern

    The MVUX pattern is a new programming architecture by Uno Platform. It stands for ***M**odel **V**iew **U**pdate e**X**tended*.
    It's main feature is enabling the use of immutable [POCO](https://en.wikipedia.org/wiki/Plain_old_CLR_object) entities and Models (using [records](https://learn.microsoft.com/en-us/dotnet/csharp/whats-new/tutorials/records)) as the presentation layer, making the whole need for implementing property change notification redundant.
    This is achieved using Uno Platform's powerful code-generation engine to introduce proxy models that adapt the models to bindable proxy types that react upon changes in the UI side by recreating the Model.  
    It also introduces [Feeds](xref:Overview.Mvux.Feeds) and [States](xref:Overview.Mvux.States), two utilities which are used to maintain asynchronous data requests to the service, Feeds only keep the data as received from the service, while States are also used to store their current state according to updates made in the View. These two utilities wrap the data around with a metadata layer which discloses information about the current state of the request, whether it's still in progress, if an error occurred, no data was returned, and also supports tracking data-selection and pagination as well as other features. These tools also support collection data using the [`ListFeed`](xref:Overview.Mvux.ListFeeds) and [`ListState`](xref:Overview.Mvux.ListStates).  
    On top of that there is also the [`FeedView`](xref:Overview.Mvux.FeedView) control which is built to consume this metadata and adapts the View according to the current state of the Model.  
    The code-generation engine also makes it easier to write commands to be consumed by the View, see [Commands](xref:Overview.Mvux.Advanced.Commands).

    To learn more about the MVUX pattern, read [this](xref:Overview.Mvux.Overview).

    #### Uno Toolkit

    The [Uno Toolkit](https://platform.uno/uno-toolkit) provides a set of controls and UI utils.  
    It enables you to easily switch themes (Fluent, Material, Cupertino), provides many UI controls and components, UI graphics utilities, and access to device sensors and other features.  
    The Uno Toolkit is demonstrated as live web app [here](https://gallery.platform.uno/). It is also available as an [iOS](https://apps.apple.com/us/app/uno-gallery/id1380984680) or [Android](https://play.google.com/store/apps/details?id=com.nventive.uno.ui.demo) app.

    > [!TIP]  
    > The Gallery app is open-source and is [available on GitHub](https://github.com/unoplatform/uno.gallery).

    This includes out-the-box support for [configuration](xref:Overview.Configuration), [app-hosting](xref:Overview.Hosting), [Dependency Injection](xref:Overview.DependencyInjection), [logging](xref:Overview.Logging), [navigation](xref:Overview.Navigation), [HttpClient factory management](xref:Overview.Http), [localization](xref:Overview.Localization), [serialization](xref:Overview.Serialization), as well as references to the new [MVUX pattern](xref:Overview.Mvux.Overview) - Uno Platforms new architecture for managing app's state, and references to the Uno Toolkit 
                
    The *Customize* button lets you customize the selected template and fine-tune which features should be included with the generated project.  
    When clicking *Customize*, a wizard opens with the pre-selected settings per the choice in the first page (*Blank* or *Default*).

> [!NOTE]  
> When the project opens for the first time, a popup may show up asking to Reload the projects, this is normal.
>
> ![](assets/reload-projects.jpg)
