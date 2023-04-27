Enables setting which Uno Extensions should be included with the generated projects.
Uno Extensions is a set of Extensions that cover common essentials application core building blocks, and are supported on all operating systems Uno Platform targets.  
The Uno.Extensions follows the Microsoft.Extensions model that creates a host environment where you can register additional dependencies. The registered dependencies are then available throughout the application via the Services (`IServiceProvider`) property on the `IHost` instance.
    
To learn more about Uno Extensions, visit [this page](xref:Overview.Features).
    
The available extensions are:
    
- General
  - **Dependency Injection**  
    This extension brings the power of [Microsoft Extensions Dependency Injection](https://learn.microsoft.com/en-us/dotnet/core/extensions/dependency-injection) to all OSs Uno Platform targets, and adds its additional functionality.  
    Refer to the [Uno Dependency Injection](xref:Overview.DependencyInjection) documentation for more information.
  - **Configuration**  
    This extension provides a way to load application configuration data from and to various sources using the [Options Pattern](https://learn.microsoft.com/en-us/dotnet/core/extensions/options).  
    Refer to the [Uno Configuration](xref:Overview.Configuration) documentation for more information.
  - **HTTP**  
    Uno HTTP extensions enables mapping different `HttpClient` configurations to different API endpoints.  
    Refer to the [Uno HTTP](xref:Overview.Http) documentation for more information.
  - **Localization**  
    The Localization extension ports [Microsoft.Extensions.Localization](https://learn.microsoft.com/en-us/dotnet/core/extensions/localization) to all OSs supported by Uno Platform.  
    Refer to the [Localization](xref:Overview.Localization) documentation for more information.
- Navigation
  - **Regions**
    Uses Uno's Region navigation.
    A Region is the abstraction of the view responsible for handling navigation. Regions are structured into a logical hierarchical representation that shadows the navigation-aware controls in the visual hierarchy. The hierarchy allows navigation requests to be propagated up to parent and down to child regions as required.  
    Refer to the [Navigation](xref:Overview.Navigation) documentation for more information.
  - **Blank**  
    Provides the default [WinUI frame navigation](https://learn.microsoft.com/en-us/uwp/api/windows.ui.xaml.controls.frame).
- Logging  
  Uno Platform's Logging Extension adapts [Microsoft Logging Extension](https://learn.microsoft.com/en-us/dotnet/core/extensions/logging) to Uno Platform apps.  
  - **Console**  
  Generates an app configured to write debug-level logging information to the Console.
  - **Default**  
  Generates an app that uses Dependency Injection to configure logging that writes output to Console.
  - **Serilog**  
  Generates an app that uses Dependency Injection to configure logging with [Serilog](https://github.com/serilog/serilog).

  Refer to the [Logging](xref:Overview.Logging) documentation for more information.
- Authentication  
  Authentication has its dedicated tab, [see below](#authentication).
