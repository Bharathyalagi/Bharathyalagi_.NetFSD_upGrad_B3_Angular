# ShopEZ - Backend API (ASP.NET Core)

## Overview

This project implements the backend of the ShopEZ e-commerce application using ASP.NET Core Web API and Entity Framework Core.
It provides APIs for managing products and processing customer orders with proper validations, business logic, and database integration.

---


## Tech Stack

* ASP.NET Core Web API
* Entity Framework Core
* SQL Server
* Swagger (API Testing)
* Postman

---

## Project Structure

```
ShopEz.API/
│
├── Controllers/
│   ├── ProductsController.cs
│   └── OrdersController.cs
│
├── Models/
│   ├── Product.cs
│   ├── Order.cs
│   └── OrderItem.cs
│
├── DTOs/
│   ├── ProductDTO.cs
│   └── OrderDTO.cs
│
├── Data/
│   └── ApplicationDbContext.cs
│
├── Repositories/
│   ├── IProductRepository.cs
│   ├── ProductRepository.cs
│   ├── IOrderRepository.cs
│   └── OrderRepository.cs
│
├── Services/
│   ├── IProductService.cs
│   ├── ProductService.cs
│   ├── IOrderService.cs
│   └── OrderService.cs
│
├── appsettings.json
├── Program.cs
└── ShopEz.API.csproj
```

---

## Architecture

The application follows layered architecture

```
Controller → Service → Repository → DbContext → Database
```

* Controller: Handles HTTP requests
* Service: Business logic and validations
* Repository: Data access layer
* DbContext: Database interaction using EF Core

---

## Database Design

### Products Table

* ProductId
* Name
* Description
* Price
* ImageUrl
* Stock

### Orders Table

* OrderId
* UserId
* OrderDate
* TotalAmount

### OrderItems Table

* OrderItemId
* OrderId
* ProductId
* Quantity
* Price

---
## Features Implemented

* Product CRUD APIs (GET, POST, PUT, DELETE)
* Order APIs (Create Order, Get All Orders, Get Order By Id)
* Order processing logic using LINQ
* Validation for product existence and quantity
* Exception handling with proper responses
* Use of DTOs to avoid direct entity exposure
* Asynchronous programming using async/await
* Dependency Injection for services and repositories
* Navigation properties for relationships
* Clean modular folder structure

---
## Validation Rules

* Product must exist before creating an order
* Quantity must be greater than zero
* Cart should not be empty

---

## Entity Framework Core Setup

Migration and database setup:

```
Add-Migration InitialCreate
Update-Database
```

---

## Running the Application

Run the project using Visual Studio or:

```
dotnet run
```

---

## API Testing

* Swagger UI: 
```
https://localhost:7256/swagger
```
* Postman used for external API testing

---

## API Endpoints

### Products

```
GET     /api/products
GET     /api/products/{id}
POST    /api/products
PUT     /api/products/{id}
DELETE  /api/products/{id}
```

### Orders

```
POST    /api/orders
GET     /api/orders
GET     /api/orders/{id}
```

---

## Postman Testing

All APIs were tested in Postman:

* Product APIs (GET, POST, PUT, DELETE)
* Order APIs (POST, GET)
* Validation scenarios (product not found, invalid quantity, empty cart)

---

## Conclusion

This project demonstrates a complete backend system for an e-commerce application using ASP.NET Core and EF Core.
It implements real-world concepts like layered architecture, database relationships, validation, and API development.

---
