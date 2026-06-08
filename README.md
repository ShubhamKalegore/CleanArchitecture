# CleanArchDemo - .NET 8 Clean Architecture Web API

A production-style **ASP.NET Core 8 Web API** built using **Clean Architecture**, **CQRS with MediatR**, **Entity Framework Core**, **JWT Authentication**, **Repository Pattern**, **Serilog Logging**, and **Unit Testing**.

The project demonstrates how to build a scalable, maintainable, and testable enterprise application by separating concerns across multiple layers.

---

## Architecture Overview

The solution follows the Clean Architecture pattern and is divided into four primary layers:

```text
┌─────────────────────────┐
│      API Layer          │
│ Controllers, Middleware │
└──────────┬──────────────┘
           │
           ▼
┌─────────────────────────┐
│   Application Layer     │
│ Services, DTOs, CQRS    │
└──────────┬──────────────┘
           │
           ▼
┌─────────────────────────┐
│      Domain Layer       │
│ Entities & Core Models  │
└──────────┬──────────────┘
           │
           ▼
┌─────────────────────────┐
│ Infrastructure Layer    │
│ EF Core, Repositories   │
└─────────────────────────┘
```

---

# Solution Structure

```text
CleanArchDemo
│
├── CleanArchDemo.API
├── CleanArchDemo.Application
├── CleanArchDemo.Domain
├── CleanArchDemo.Infrastructure
└── CleanArchDemo.Application.Tests
```

---

# Project Layers

## CleanArchDemo.API

Presentation layer responsible for handling HTTP requests.

### Features

* ASP.NET Core 8 Web API
* Swagger/OpenAPI documentation
* JWT Authentication & Authorization
* Serilog Logging
* CORS Configuration
* Global Middleware
* Dependency Injection Configuration
* API Controllers

### Controllers

* AuthController
* UsersController
* ProductsController
* StudentsController

### Middleware

* RequestLoggingMiddleware

---

## CleanArchDemo.Application

Contains business logic and application use cases.

### Features

* DTOs
* Service Interfaces
* Service Implementations
* AutoMapper Profiles
* MediatR
* CQRS Pattern
* Validation-ready architecture

### DTO Modules

* Authentication
* Users
* Products
* Students
* Courses
* Notifications
* Support Messages

### CQRS Implementation

#### Commands

* Create User

#### Queries

* Get Users
* Get User By Id

Implemented using:

* MediatR
* Command Handlers
* Query Handlers

---

## CleanArchDemo.Domain

Contains enterprise business entities and core models.

### Entities

* User
* Product
* Student
* Course
* Notification
* SupportMessage

This layer has no dependency on any external framework.

---

## CleanArchDemo.Infrastructure

Responsible for persistence and external dependencies.

### Features

* Entity Framework Core
* SQL Server Integration
* Repository Pattern
* Database Migrations

### Repositories

* UserRepository
* ProductRepository
* StudentRepository

### Database

* AppDbContext
* EF Core Migrations
* SQL Server Provider

---

## CleanArchDemo.Application.Tests

Unit testing project.

### Technologies

* xUnit
* Moq
* Coverlet

### Tested Components

* AuthService
* UserService
* ProductService
* StudentService
* User CQRS Handlers

---

# Dependency Injection Using Extension Methods

To keep `Program.cs` clean and maintainable, dependency registrations are moved into dedicated extension methods.

### Application Layer

A custom extension method is created inside the Application layer for registering:

* Application Services
* AutoMapper
* MediatR
* Other Application Dependencies

Example:

```csharp
builder.Services.AddApplication();
```

---

### Infrastructure Layer

A custom extension method is created inside the Infrastructure layer for registering:

* Repositories
* DbContext
* SQL Server Configuration
* Infrastructure Services

Example:

```csharp
builder.Services.AddInfrastructure(builder.Configuration);
```

This approach follows the Single Responsibility Principle and keeps startup configuration organized.

---

# Authentication Features

The project includes JWT-based authentication.

### Supported Features

* User Registration
* User Login
* Access Tokens
* Refresh Tokens
* Secure API Endpoints
* Role-Based Authorization

---

# Student Management Features

### Operations

* Create Student
* Update Student
* Delete Student
* Get Student By Id
* Get All Students

### Additional Features

* Student Filtering
* Student Sorting
* Student With Course Information

---

# Product Management Features

### Operations

* Create Product
* Update Product
* Delete Product
* Get Product By Id
* Get All Products

---

# Course Management

### Operations

* Create Course
* Get Courses

---

# Notification & Support Modules

Database entities included for:

* Notifications
* Support Messages

These demonstrate how additional business modules can be added while maintaining architectural boundaries.

---

# Logging

Implemented using Serilog.

### Benefits

* Structured Logging
* Request Tracking
* Easier Debugging
* Production Monitoring

---

# Technologies Used

* .NET 8
* ASP.NET Core Web API
* Entity Framework Core
* SQL Server
* MediatR
* AutoMapper
* JWT Authentication
* Serilog
* xUnit
* Moq
* Coverlet
* Swagger/OpenAPI

---

# Design Patterns Used

* Clean Architecture
* Repository Pattern
* Dependency Injection
* CQRS Pattern
* Middleware Pattern
* Service Layer Pattern

---

# Running the Project

## Clone Repository

```bash
git clone https://github.com/your-username/CleanArchDemo.git
```

## Navigate to Project

```bash
cd CleanArchDemo
```

## Apply Migrations

```bash
dotnet ef database update
```

## Run Application

```bash
dotnet run
```

## Open Swagger

```text
https://localhost:<port>/swagger
```

---

# Testing

Run all tests:

```bash
dotnet test
```

---

# Future Enhancements

* Fluent Validation
* Global Exception Handling
* Redis Caching
* API Versioning
* Docker Support
* Background Jobs (Hangfire)
* Event-Driven Architecture
* Microservices Migration

---

# Learning Objectives

This project demonstrates:

* Clean Architecture Implementation
* Layered Separation of Concerns
* CQRS with MediatR
* JWT Authentication
* Repository Pattern
* Entity Framework Core
* Dependency Injection via Extension Methods
* Unit Testing with xUnit and Moq
* Production-Oriented API Design

---

## Author

Developed as a learning and portfolio project to demonstrate modern .NET backend development practices using Clean Architecture and enterprise design principles.
