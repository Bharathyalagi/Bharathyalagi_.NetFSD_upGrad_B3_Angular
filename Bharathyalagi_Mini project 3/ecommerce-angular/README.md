# ShopEZ - Full Stack E-Commerce Application

## Project Overview

ShopEZ is a full-stack e-commerce web application built using:

- **Frontend:** Angular (Standalone Components)
- **Backend:** ASP.NET Core Web API
- **Database:** SQL Server
- **Authentication:** JWT (JSON Web Token)

This project demonstrates a complete end-to-end system including product management, cart functionality, order processing, and secure authentication.

---

## Features

### Authentication

- User Registration (stored in database)
- User Login using JWT
- Initially hardcoded login (Bharath / Bharath@7)
- Later upgraded to dynamic DB-based authentication

---

### Product Management

- View all products
- Add / Delete products (Admin)
- Product images support

---

### Cart System

- Add to cart
- Increase / Decrease quantity
- Remove items
- Total price calculation

---

### Orders

- Place order from cart
- Order stored in database
- View all orders

---

### Security

- JWT Token generation
- HTTP Interceptor to attach token
- Route Guard to protect Admin routes

---

## Backend Architecture

### Structure

Controllers:

- AuthController
- ProductsController
- OrdersController

Services:

- OrderService
- ProductService

Repositories:

- OrderRepository

Data:

- ApplicationDbContext

Models:

- User
- Product
- Order
- OrderItem

---

### Database Tables

- Users
- Products
- Orders
- OrderItems

---

## Frontend Architecture

### Structure

```bash
src/app
│   app.config.ts
│   app.routes.ts
│   app.html
│
├── components
│   ├── cart
│   ├── checkout
│   ├── product-list
│   ├── product-details
│
├── pages
│   ├── home
│   ├── login
│   ├── register
│   ├── admin
│   ├── orders
│
├── services
│   ├── product.service.ts
│   ├── order.service.ts
│   ├── cart.ts
│   ├── auth.interceptor.ts
│
├── guards
│   └── auth-guard.ts
```

---

## Setup Instructions

### Backend (ASP.NET Core)

```bash
cd ShopEz.API
dotnet restore
dotnet build
dotnet run
```

### Database Setup

```bash
Add-Migration InitialCreate
Update-Database
```

---

### Frontend (Angular)

```bash
cd ecommerce-angular
npm install
ng serve
```

Open browser:

```bash
http://localhost:4200
```

---

## API Endpoints

### Auth

```
POST /api/Auth/register
POST /api/Auth/login
```

### Products

```
GET    /api/products
POST   /api/products
PUT    /api/products/{id}
DELETE /api/products/{id}
```

### Orders

```
POST /api/orders
GET  /api/orders
GET  /api/orders/{id}
```

---

## Project Flow

1. User registers → data stored in DB
2. User logs in → JWT token generated
3. Token stored in browser (localStorage)
4. Interceptor attaches token to API calls
5. User browses products
6. Adds items to cart
7. Checkout → Order sent to backend
8. Backend calculates total + stores order
9. Orders page fetches and displays data

---

## Testing

Run Angular unit tests:

```bash
ng test
```

Tested:

- ProductService

---

## What We Achieved

- Full Frontend + Backend Integration
- Secure Authentication using JWT
- Real Database storage (no hardcoding)
- Complete E-Commerce Flow
- Clean UI with Angular Standalone Components

---

## Future Enhancements

- Password hashing (bcrypt)
- Role-based UI (Admin/User)
- Payment integration
- Order history per user
- UI improvements

---

## Author

Developed as part of Full Stack training project.

---

## Notes

- Backend must be running before frontend
- JWT token required for protected APIs
- SQL Server should be configured correctly

---

## Final Status

✔ Fully Functional
✔ Evaluation Ready
✔ Production-Level Structure (Basic)

---
