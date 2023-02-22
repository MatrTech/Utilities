# Matr.Utilitis
This is a general usage package with ulitities to make setting up your code more easy. It provides some different kinds of utilities all focused on removing the boilerplate code needed to manage code projects.For starters it provides a lightweight dependency factory to manage all the dependencies. Making it easily and safe to register and replace dependencies.

## Installing
The package is easily installed using nuget.
```
Install-Package MatrTech.Utilities
```

## Using the package
```csharp
using namespace Matr.Utilities;
```

That's it, now you can use the package.

## Package in action

When you have the following class with a dependency

```csharp
public class Service
{
    public Service(IDependency dependency)
    {
        this.dependency = dependency;
    }
}
```

This could be created using the `GenericFactory`

```csharp
GenericFactory factory = new GenericFactory();
factory.RegisterOrReplace<IDependency, Dependency>();

...

var service = factory.Create<Service>();

```
