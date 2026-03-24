# C# Fundamentals - DevTalles Course

[![.NET](https://img.shields.io/badge/.NET-8.0-512BD4)](https://dotnet.microsoft.com/)
[![C#](https://img.shields.io/badge/C%23-12.0-239120)](https://docs.microsoft.com/en-us/dotnet/csharp/)
[![License](https://img.shields.io/badge/License-MIT-green.svg)](LICENSE)

> **Note:** This repository contains the foundational C# concepts learned **before** diving into .NET API development. It covers essential programming principles that form the basis for building robust backend applications.

## 📋 Table of Contents

- [About](#about)
- [Prerequisites](#prerequisites)
- [Getting Started](#getting-started)
- [Project Structure](#project-structure)
- [Core Concepts Covered](#core-concepts-covered)
- [Running the Project](#running-the-project)
- [Learning Path](#learning-path)
- [Technologies](#technologies)
- [Contributing](#contributing)

## 🎯 About

This project is part of the **DevTalles .NET Backend learning path**. It demonstrates fundamental C# concepts through practical examples using a product management system. Each folder in the `Fundamentals` directory represents a key concept with hands-on implementations.

This serves as the foundation before moving on to building RESTful APIs with ASP.NET Core.

## 📚 Prerequisites

Before running this project, make sure you have:

- **.NET 8 SDK** installed ([Download here](https://dotnet.microsoft.com/download/dotnet/8.0))
- **IDE** (one of the following):
  - Visual Studio 2022 or later
  - Visual Studio Code with C# extension
  - JetBrains Rider
- Basic understanding of programming concepts

### Verify Installation

```bash
dotnet --version
```

Expected output: `8.0.x` or higher

## 🚀 Getting Started

### Clone the Repository

```bash
git clone https://github.com/mabalderramav/devtalles-cs-bases-api-net.git
cd devtalles-cs-bases-api-net
```

### Restore Dependencies

```bash
dotnet restore
```

### Build the Project

```bash
dotnet build
```

### Run the Application

```bash
dotnet run
```

## 📁 Project Structure

```
CsBases/
├── Fundamentals/
│   ├── 02-Tipos-Basicos/
│   │   └── DataTypes.cs                    # Basic data types in C#
│   ├── 04-Herencia/
│   │   ├── IProduct.cs                     # Interface definition
│   │   ├── Product.cs                      # Base class with properties & methods
│   │   └── ServiceProduct.cs               # Inheritance example
│   ├── 05-Patron-Adaptador/
│   │   ├── ProductDto.cs                   # Data Transfer Object
│   │   └── ProductAdapter.cs               # Adapter pattern implementation
│   ├── 06-Inyeccion-dependencias/
│   │   ├── ILabelService.cs                # Service interface
│   │   ├── LabelService.cs                 # Service implementation
│   │   └── ProductManager.cs               # Dependency injection consumer
│   ├── 07-Metodos-Asincronos/
│   │   └── ProductRepository.cs            # Async/await patterns
│   └── 08-Atributos/
│       ├── UpperCaseAttribute.cs           # Custom attribute
│       └── AttributeProcessor.cs           # Reflection-based processor
├── Program.cs                              # Main entry point
└── CsBases.csproj                          # Project configuration
```

## 💡 Core Concepts Covered

### 1. **Basic Data Types** (`02-Tipos-Basicos`)
- Primitive types: `int`, `string`, `decimal`, `bool`, `DateTime`
- Value types vs Reference types
- `Guid` for unique identifiers

### 2. **Object-Oriented Programming** (`04-Herencia`)
- **Classes and Objects**: `Product`, `ServiceProduct`
- **Interfaces**: `IProduct`
- **Inheritance**: `ServiceProduct` extends `Product`
- **Polymorphism**: `virtual` and `override` keywords
- **Encapsulation**: Properties with getters/setters

**Example:**
```csharp
public class Product : IProduct
{
    public string? Name { get; set; }
    public decimal Price { get; set; }
    
    public virtual string GetDescription()
    {
        return $"{Name} - {Price:C}";
    }
}

class ServiceProduct : Product
{
    public int DurationInDays { get; set; }
    
    public override string GetDescription()
    {
        return $"{base.GetDescription()} - Duración: {DurationInDays} días";
    }
}
```

### 3. **Design Patterns**

#### Adapter Pattern (`05-Patron-Adaptador`)
Converts the interface of a class into another interface expected by clients.

```csharp
// Adapts Product to ProductDto
var productDto = ProductAdapter.ToDto(product);
```

#### Dependency Injection (`06-Inyeccion-dependencias`)
Promotes loose coupling and testability.

```csharp
ILabelService labelService = new LabelService();
var manager = new ProductManager(labelService);
manager.PrintLabel(product);
```

### 4. **Asynchronous Programming** (`07-Metodos-Asincronos`)
- `async` and `await` keywords
- `Task<T>` return types
- Simulating async operations (database calls, API requests)

```csharp
public async Task<Product> GetProduct(int id)
{
    await Task.Delay(2000); // Simulate async operation
    return new Product("Producto simulado", 500);
}
```

### 5. **Attributes and Reflection** (`08-Atributos`)
- Custom attributes: `[UpperCase]`
- Reflection API for runtime type inspection
- Property manipulation

```csharp
[UpperCase]
public string? Name { get; set; }

// Processor applies transformation at runtime
AttributeProcessor.ApplyUpperCase(product);
```

## ▶️ Running the Project

When you run the application, it demonstrates all concepts:

```bash
dotnet run
```

**Expected Output:**
```
Laptop - $1,200.00
Technical Support - $300.00 - Duración: 30 días
Mouse Gamer - $300.00 - Código: P-0-xxxxxxxx
Etiqueta: Monitor - $100.00
Etiqueta: Instalación de monitor - $20.00 - Duración: 30 días
Buscando producto...
PRODUCTO SIMULADO - 500 - ESTA ES LA DESCRIPCIÓN DEL PRIMER PRODUCTO
```

## 🎓 Learning Path

This repository is the **first step** in the DevTalles .NET Backend course:

1. ✅ **C# Fundamentals** (This Repository)
   - Data types, OOP, patterns, async programming
   
2. ⏭️ **ASP.NET Core Web API** (Next Step)
   - REST APIs, controllers, middleware
   - Entity Framework Core
   - Authentication & Authorization
   - API documentation with Swagger

3. 🎯 **Advanced Topics**
   - Clean Architecture
   - CQRS and MediatR
   - Microservices
   - Docker & Kubernetes

## 🛠️ Technologies

- **Language:** C# 12.0
- **Framework:** .NET 8
- **Target:** Console Application
- **Concepts:** OOP, SOLID, Design Patterns, Async Programming

## 📖 Additional Resources

- [Official .NET Documentation](https://docs.microsoft.com/en-us/dotnet/)
- [C# Programming Guide](https://docs.microsoft.com/en-us/dotnet/csharp/)
- [Design Patterns in C#](https://refactoring.guru/design-patterns/csharp)
- [Async/Await Best Practices](https://docs.microsoft.com/en-us/archive/msdn-magazine/2013/march/async-await-best-practices-in-asynchronous-programming)

## 🤝 Contributing

This is a learning project, but contributions are welcome! Feel free to:

1. Fork the repository
2. Create a feature branch (`git checkout -b feature/NewConcept`)
3. Commit your changes (`git commit -m 'Add some concept'`)
4. Push to the branch (`git push origin feature/NewConcept`)
5. Open a Pull Request

## 📝 License

This project is licensed under the MIT License - see the [LICENSE](LICENSE) file for details.

## 👨‍💻 Author

**Miguel Angel Balderrama**
- GitHub: [@mabalderramav](https://github.com/mabalderramav)

## ⭐ Acknowledgments

- **DevTalles** - For the excellent .NET Backend course
- The .NET Community for continuous support and resources

---

**Happy Coding! 🚀**

*Preparing for the next step: Building RESTful APIs with ASP.NET Core*
