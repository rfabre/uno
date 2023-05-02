Enables setting which Uno Extensions should be included with the generated projects.
Uno Extensions is a set of Extensions that cover common essentials application core building blocks, and are supported on all operating systems Uno Platform targets.  
The Uno.Extensions follows the Microsoft.Extensions model that creates a host environment where you can register additional dependencies. The registered dependencies are then available throughout the application via the Services (`IServiceProvider`) property on the `IHost` instance.
    
To learn more about Uno Extensions, visit [this page](xref:Overview.Features).
    
The available extensions are:
    
- **General**
  - **Dependency Injection**
    Dependency Injection (DI) is an Inversion of Control (IoC) technique which enables consuming classes not to worry about the management or creation of their dependencies, and instead rely on a central service to provide it when needed, based how the provider was configured.      
    Uno Platform brings the power of [Microsoft Extensions Dependency Injection](https://learn.microsoft.com/en-us/dotnet/core/extensions/dependency-injection) to all OSs Uno Platform targets, and adds its additional functionality via its Uno.Extensions.DependencyInjection library, which you can learn more about [here](xref:Overview.DependencyInjection).

  - **Configuration**  
    This extension provides a way to load application configuration data from and to various sources using the [Options Pattern](https://learn.microsoft.com/en-us/dotnet/core/extensions/options).
    Refer to the [Uno Configuration](xref:Overview.Configuration) documentation for more information.

  - **HTTP**
    Uno.Extensions.Http allows for the registration of API endpoints as multiple typed HttpClient instances. In this centralized location for accessing web resources, the lifecycle of the corresponding HttpMessageHandler objects is managed. Added clients can optionally be configured to use the platform-native handler. Additional functionality is provided to clear cookies or log diagnostic messages in responses. This library uses Microsoft.Extensions.Http for any HTTP related work.
    For more documentation on HTTP requests, [read the documentation](xref:Overview.Http).

    Another related package installed with the default template is Refit. This is a port of the [Refit library](https://github.com/reactiveui/refit) that enables mapping REST APIs into .NET interfaces.
    Refer to the [documentation](xref:Overview.Http#refit) to learn how to use it in an Uno Platform app.

  - **Localization**
    The Localization extension is responsible for managing globalization of your app.  
    This enables keeping all translations of your app in a single place and enables the user to easily switch the UI language.

    The generated app contains *resw* files which can be used to define the application strings. The defined languages are configured in *appsettings.json*. Follow [this link](Learn.Tutorials.Localization.HowToUseLocalization#3-update-the-ui-culture-with-localizationsettings) to learn how to switch the UI culture.

    ![](Assets/localization.jpg)
    
    The default settings comes with the following pre-set languages: English (*en*), Spanish (*es*), French (*fr*), and Potuguese - Brazil (*pt-BR*).

    Uno.Extensions.Localization expands [Microsoft.Extensions.Localization](https://learn.microsoft.com/en-us/dotnet/core/extensions/localization) to all OSs supported by Uno Platform.  
    Read the full Localization documentation [here](xref:Overview.Localization) or learn more about [Globalization](https://learn.microsoft.com/en-us/dotnet/core/extensions/globalization).

- **Navigation**
  - **Regions**
    Navigation is an integral part of any app and for that, Uno Platform has developed a navigation system that is registered and served using DI and is fully integrated with the navigation specific UI controls out-there, such as `Frame`, `NavigationView`, and `TabBar`.  
    It is a region-based navigation. A Region is the abstraction of the view responsible for handling navigation. Regions are structured into a logical hierarchical representation that shadows the navigation-aware controls in the visual hierarchy. The hierarchy allows navigation requests to be propagated up to parent and down to child regions as required.  
    This library is also responsible for showing pop-ups, flyouts, dialogs, and other interactions with the user.  
    Learn more about Uno's Navigation library [here](xref:Overview.Navigation).

  - **Blank**  
    Provides the default [WinUI frame navigation](https://learn.microsoft.com/en-us/uwp/api/windows.ui.xaml.controls.frame).

- **Logging**  
    Logging is a crucial component in an app that enables the developer to emit log messages whenever an important action or execution is taken by the app. This then lets you trace back any errors or issues that may arise in the future.
    There are several Logging tools out there, with one of the most common of them being [Microosft.Extensions.Logging](https://learn.microsoft.com/en-us/dotnet/core/extensions/logging).  
    Uno Platform provides its Uno.Extensions.Logging to bring Logging to all platforms it supports.      
    Uno.Extensions.Logging is covered in more detail [here](xref:Overview.Logging).

  - **Console**  
  Generates an app configured to write debug-level logging information to the Console.

  - **Default**  
  Generates an app that uses Dependency Injection to configure logging that writes output to Console.

  - **Serilog**  
  Generates an app that uses Dependency Injection to configure logging with [Serilog](https://github.com/serilog/serilog).

  Refer to the [Logging](xref:Overview.Logging) documentation for more information.

- **Authentication**  
  Authentication has its dedicated tab, [see below](#authentication).

![](assets/extensions.jpg)
