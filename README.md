# **What is Modular Monolithic Architecture?**

Modular Monolithic Architecture is a software architecture that combines the **benefits of modular design** with the **simplicity** of a **monolithic** architecture. It involves dividing the system into a set of **loosely-coupled modules**, each with a well-defined boundary and explicit dependencies on other modules.
![](./ProjectDoc/images/Aspose.Words.06c15b47-3dbe-49a6-b063-646cf506a56f.001.png)

## **Benefits Of Modular Monolith:**

- The modular monolithic architecture **divided our application logic into modules**
- Eacch module will be **independent** and **isolated**
- Each module should have its own business logic — and, if necessary, its database or schema.
- Deploying a modular monolith is simpler compared to distributed systems, as there’s only one deployment artifact to manage
- A well-structured modular monolith offers a clear path to a micro services architecture. We can separate the module to an independent service when the need arises.

  Read More:

- [What Is a Modular Monolith? - GeeksforGeeks](https://www.geeksforgeeks.org/what-is-a-modular-monolith/)
- [What Is a Modular Monolith? (milanjovanovic.tech)](https://www.milanjovanovic.tech/blog/what-is-a-modular-monolith)

Mediator Pattern

![](./ProjectDoc/images/Aspose.Words.06c15b47-3dbe-49a6-b063-646cf506a56f.002.png)

#### **Description**

The Mediator Pattern reduces complexity and dependencies between objects by introducing a mediator. This mediator handles communication between components, promoting loose coupling.

#### **Components**

- **Mediator Interface**: Defines communication methods.
- **Concrete Mediator**: Implements the mediator interface, managing interactions.
- **Colleagues**: Components that communicate via the mediator.

### **Benefits of the Mediator Pattern**

1. **Reduces Coupling**: Objects don't directly reference each other.
1. **Improves Readability**: Centralizes complex communication logic.
1. **Enhances Flexibility**: Interaction changes don't affect components.
1. **Simplifies Interactions**: Manages many-to-many relationships.
1. **Promotes SRP**: Components focus on primary tasks, mediator handles communication.

### **Benefits of Using the Mediator Pattern in ASP.NET**

1. **Centralized Logic**: Easier to manage and modify request handling.
1. **Separation of Concerns**: Decouples sender and receiver.
1. **Improved Maintainability**: Communication changes don't affect components.
1. **Simplifies Testing**: Easier to mock interactions in unit tests.
1. **Reduces Boilerplate**: Libraries like MediatR streamline request handling.
1. **Enhanced Readability**: Centralized handling improves code organization.
1. **Scalability**: Facilitates adding and modifying features.

To Read more about mediator patter: [Mediator (refactoring.guru)](https://refactoring.guru/design-patterns/mediator)

Clean Ar![](./ProjectDoc/images/Aspose.Words.06c15b47-3dbe-49a6-b063-646cf506a56f.003.png)chitecture:

Onion Architecture is a software design pattern that promotes loose coupling, high cohesion, and separation of concerns. Let’s dive into the details:

1. Principles of Onion Architecture:

- Inversion of Control (IoC): The architecture relies on IoC, where layers interface with each other toward the core (representing the domain). Unlike traditional multi-tier architectures, it doesn’t depend on the data layer but focuses on actual domain models.
- Core Domain Layer: At the center, we have the domain layer, housing business and behaviour objects. This layer is independent of external dependencies.
- Layer Flow: The flow of dependencies moves from outer layers toward the core, reducing unnecessary coupling.

1. Layers of Onion Architecture:

- Domain Layer: Contains domain objects (business logic) at the core. Interfaces define interactions with other layers.
- Application Services Layer: Coordinates domain objects, handles use cases, and interfaces with external systems.
- Infrastructure Layer: Deals with external concerns like databases, UI, and frameworks. It depends on the inner layers but not vice versa.

1. Benefits:

- Maintainability: Clear separation makes it easier to modify and extend the codebase.
- Testing: Loose coupling enables effective unit testing.
- Flexibility: Reuse components across different applications.
- Identifying Issues: Clear boundaries help identify and fix issues efficiently.

Read More: [Clean Architecture in ASP.NET Core - NDepend Blog](https://blog.ndepend.com/clean-architecture-for-asp-net-core-solution/)

Project Structure:

![](./ProjectDoc/images/Aspose.Words.06c15b47-3dbe-49a6-b063-646cf506a56f.004.png)

The Main project is a webApi (SmartFM) Project. Other Projects are class library project.

The projects are connected with references. We can think this project is a single project. But logically separated. In future we can separate the projects by creating a new project and cut the module and add reference

Module Structure:

![](./ProjectDoc/images/Aspose.Words.06c15b47-3dbe-49a6-b063-646cf506a56f.005.png)

Here the module structure follows clean architecture.

- ` `Core is consisting of domain models and business logic.
- The main is containing Controllers and others
- The infrastructure is containing Database layer

Project References:

![](./ProjectDoc/images/Aspose.Words.06c15b47-3dbe-49a6-b063-646cf506a56f.006.png)

Shared project reference:

![](./ProjectDoc/images/Aspose.Words.06c15b47-3dbe-49a6-b063-646cf506a56f.007.png)

Api Project Reference:

![](./ProjectDoc/images/Aspose.Words.06c15b47-3dbe-49a6-b063-646cf506a56f.008.png)

For Example, pick water pump module. The project contains all reference of shared module. And internal module reference. The shared module reference is shown in Red Arrow and The Internal reference in Green Arrow

Package of the project:

![](./ProjectDoc/images/Aspose.Words.06c15b47-3dbe-49a6-b063-646cf506a56f.009.png)

As All other modules take reference of shared module. So, the packages are installed are in only shared module.

- The package in shared used for provide controller properties

  - **Microsoft.AspNetCore.Mvc.Core**:
    - Purpose: Provides essential MVC components and features for building web applications using the Model-View-Controller (MVC) pattern in ASP.NET Core.
    - Key Features: Includes controllers, action results, model binding, validation, routing, filters, dependency injection, middleware integration, and facilitates development of web APIs and web applications handling HTTP requests and responses efficiently.

- In core the package mediatR use for resolve request from modules and transfer data. Efcore is use for relation query
  - **Entity Framework Core (EF Core):** Simplifies database access and management through object-relational mapping (ORM) in .NET applications.
  - **MediatR**: Facilitates decoupled communication between components using the mediator pattern in .NET applications.
- In Infrastructure the packages are used for database migration and generating Database models
  - **Entity Framework Core (EF Core)**: Provides the core ORM functionalities and APIs for .NET applications.
  - **Microsoft.EntityFrameworkCore.SqlServer**: A database provider for EF Core, specifically optimized for SQL Server interactions.
  - **Microsoft.EntityFrameworkCore.Tools**: Command-line tools for EF Core, aiding in database migrations, scaffolding, and other development tasks.

WebApi project packages:

![](./ProjectDoc/images/Aspose.Words.06c15b47-3dbe-49a6-b063-646cf506a56f.010.png)

- In web api project the Efcore design and swagger package
  - **Microsoft.EntityFrameworkCore.Design:** Facilitates EF Core database migrations and scaffolding DbContext and entity classes from existing schemas, integrating command-line tools (dotnet ef) for streamlined development workflows.
  - **Swashbuckle.AspNetCore:** Automatically generates Swagger/OpenAPI documentation for ASP.NET Core Web APIs, enabling interactive documentation and testing through Swagger UI.

How the project integrated infernally explained below:

First how the project detects the controllers from different class library project.

In shared>Infrastructure>Helper> InternalControllerFeatureProvider

![](./ProjectDoc/images/Aspose.Words.06c15b47-3dbe-49a6-b063-646cf506a56f.011.png)
A BaseController is also introduced in
Shared>Shared>Controllers> BaseController
![](./ProjectDoc/images/Aspose.Words.06c15b47-3dbe-49a6-b063-646cf506a56f.012.png)

Which Contains definition of ApiController. And initialize ISender from MediatR. ISender will help to resolve query requests by scanning the Assembly reference. Later part will discuss the process
