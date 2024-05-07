# Dependency Injection (DI)

Dependency Injection (DI) is a design pattern that helps you create more maintainable and testable code by separating the creation of dependencies from the classes that use them. This separation of concerns allows for cleaner code and more modular, flexible applications.

The three main types of DI are:

1. **Constructor Injection**: Dependencies are provided through the constructor of a class.
2. **Method Injection**: Dependencies are provided through a method parameter of a class.
3. **Property Injection**: Dependencies are provided through public properties of a class.

Here's a brief overview of each type of DI with examples:

1. **Constructor Injection**:

```csharp
public class MyClass
{
    private readonly IMyService _myService;

    public MyClass(IMyService myService)
    {
        _myService = myService;
    }

    public void DoSomething()
    {
        _myService.MyMethod();
    }
}
```

2. **Method Injection**:

```csharp
public class MyClass
{
    public void DoSomething(IMyService myService)
    {
        myService.MyMethod();
    }
}
```

3. **Property Injection**:

```csharp
public class MyClass
{
    public IMyService MyService { get; set; }

    public void DoSomething()
    {
        MyService?.MyMethod();
    }
}
```

### Dependency Injection (DI) Container

A DI container is a framework that automates the process of providing dependencies to classes. It manages the lifecycle of objects, including their creation and destruction. It is responsible for registering services and resolving dependencies.

Key operations of a DI container include:

- **Registering services**: Specifying the type of dependencies to be provided for a given interface or class.
- **Resolving services**: Providing the required instance of a service when needed.
- **Managing lifetimes**: Controlling how long a service instance should live (e.g., transient, scoped, singleton).
  - Transient:
  - A new instance of the service is created each time it is requested.
        This is ideal for lightweight, stateless services or when the service contains internal state that should not be shared across requests.
  - Scoped:
    - A new instance of the service is created for each scope (e.g., per web request in an ASP.NET Core application).
    - This is useful when you want to share a single instance of a service within the context of a request, while keeping instances separate between different requests.
    - In ASP.NET Core, the lifetime of a scoped service aligns with the duration of an HTTP request.
  - Singleton:
    - A single instance of the service is created and shared throughout the lifetime of the application.
    - This is suitable for services that need to maintain state or that manage shared resources (e.g., a connection pool).
    - Be cautious when using singletons, especially if the service is not thread-safe, as it will be shared across the application.

Here’s an example using the `Microsoft.Extensions.DependencyInjection` package:

```csharp
using Microsoft.Extensions.DependencyInjection;

var serviceCollection = new ServiceCollection();

// Register services
serviceCollection.AddTransient<IMyService, MyService>();

// Build the service provider (DI container)
var serviceProvider = serviceCollection.BuildServiceProvider();

// Resolve an instance of MyClass (dependencies will be automatically provided)
var myClass = serviceProvider.GetRequiredService<MyClass>();
```

### Microsoft.Extensions.DependencyInjection

`Microsoft.Extensions.DependencyInjection` is a package provided by Microsoft that offers a lightweight and easy-to-use dependency injection container. It provides an implementation of the DI pattern and supports registration and resolution of services with various lifetimes (transient, scoped, singleton).

Key features:

- **Service Collection**: Allows you to register services.
- **Service Provider**: Provides the registered services to classes.
- **Service Lifetime**: You can specify the lifetime of services, such as transient, scoped, or singleton.

Here's how you can use the package:

1. **Add the package**:

```bash
dotnet add package Microsoft.Extensions.DependencyInjection
```

2. **Register services**:

```csharp
using Microsoft.Extensions.DependencyInjection;

var serviceCollection = new ServiceCollection();
serviceCollection.AddTransient<IMyService, MyService>();
```

3. **Build the service provider**:

```csharp
var serviceProvider = serviceCollection.BuildServiceProvider();
```

4. **Resolve services**:

```csharp
var myService = serviceProvider.GetRequiredService<IMyService>();
```

### Summary

- **Dependency Injection (DI)** is the design pattern that helps in managing dependencies in a modular and maintainable way.
- **Dependency Injection (DI) Container** is a framework that manages the registration, resolution, and lifecycle of services and their dependencies.
- **Microsoft.Extensions.DependencyInjection** is a package that provides an implementation of the DI pattern in .NET, with a lightweight and easy-to-use API for managing services.

## Scrutor

Scrutor is an open-source library for .NET that extends the functionality of the built-in dependency injection framework in .NET Core. It provides a set of extension methods for the IServiceCollection interface, which can be used to register and configure services in a more convenient and flexible way.
