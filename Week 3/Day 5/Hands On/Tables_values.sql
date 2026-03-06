CREATE DATABASE EcommDb;
USE EcommDb;

--tables
CREATE TABLE Categories
(
CategoryID INT PRIMARY KEY,
CategoryName VARCHAR(50)
);

CREATE TABLE Brands
(
BrandID INT PRIMARY KEY,
BrandName VARCHAR(50)
);

CREATE TABLE Products
(
ProductID INT PRIMARY KEY,
ProductName VARCHAR(100),
BrandID INT,
CategoryID INT,
ModelYear INT,
ListPrice DECIMAL(10,2),

FOREIGN KEY (BrandID) REFERENCES Brands(BrandID),
FOREIGN KEY (CategoryID) REFERENCES Categories(CategoryID)
);

CREATE TABLE Customers
(
CustomerID INT PRIMARY KEY,
CustomerName VARCHAR(100),
City VARCHAR(50)
);

CREATE TABLE Stores
(
StoreID INT PRIMARY KEY,
StoreName VARCHAR(100),
City VARCHAR(50)
);

CREATE TABLE Staff
(
StaffID INT PRIMARY KEY,
StaffName VARCHAR(100),
StoreID INT,
FOREIGN KEY (StoreID) REFERENCES Stores(StoreID)
);

CREATE TABLE Orders
(
OrderID INT PRIMARY KEY,
CustomerID INT,
StoreID INT,
StaffID INT,

FOREIGN KEY (CustomerID) REFERENCES Customers(CustomerID),
FOREIGN KEY (StoreID) REFERENCES Stores(StoreID),
FOREIGN KEY (StaffID) REFERENCES Staff(StaffID)
);

--insert
INSERT INTO Categories VALUES
(1,'Bike'),
(2,'Car'),
(3,'Scooter'),
(4,'Truck'),
(5,'Electric');

INSERT INTO Brands VALUES
(1,'Honda'),
(2,'Toyota'),
(3,'Tesla'),
(4,'Suzuki'),
(5,'Ford');

INSERT INTO Products VALUES
(1,'Honda Shine',1,1,2022,90000),
(2,'Toyota Corolla',2,2,2023,1500000),
(3,'Tesla Model 3',3,5,2024,3500000),
(4,'Suzuki Access',4,3,2023,80000),
(5,'Ford F150',5,4,2022,2800000);

INSERT INTO Customers VALUES
(1,'Rahul','Hyderabad'),
(2,'Amit','Bangalore'),
(3,'Sneha','Hyderabad'),
(4,'Priya','Chennai'),
(5,'Karan','Mumbai');

INSERT INTO Stores VALUES
(1,'AutoHub','Hyderabad'),
(2,'CarZone','Bangalore'),
(3,'MotoWorld','Chennai'),
(4,'VehicleMart','Mumbai'),
(5,'SpeedAuto','Delhi');

INSERT INTO Staff VALUES
(1,'Bharath',1),
(2,'Bhuvan',2),
(3,'Sushmita',3),
(4,'Sumanth',4),
(5,'Ajith',5);

INSERT INTO Orders VALUES
(101,1,1,1),
(102,2,2,2),
(103,3,1,1),
(104,4,3,3),
(105,5,4,4);