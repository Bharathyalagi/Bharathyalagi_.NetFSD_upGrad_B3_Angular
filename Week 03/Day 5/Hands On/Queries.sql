--level 1 problem 1
-- 1st question
SELECT P.ProductName, B.BrandName, C.CategoryName, P.ModelYear, P.ListPrice
FROM Products P
JOIN Brands B
ON P.BrandID = B.BrandID
JOIN Categories C
ON P.CategoryID = C.CategoryID;

SELECT * FROM Products;
SELECT * FROM Brands;
SELECT * FROM Categories;

--2nd question
SELECT * FROM Customers
WHERE City = 'Bangalore';

SELECT * FROM Customers;

--3rd question
SELECT c.CategoryName, COUNT(p.ProductID) AS TotalProducts
FROM Categories as c
JOIN Products as p
ON c.CategoryID = p.CategoryID
GROUP BY c.CategoryName;

SELECT * FROM Categories;
SELECT * FROM Products;


--Level 1 Problem 2
-- 1st question 
CREATE VIEW ProductView
AS
SELECT P.ProductName, B.BrandName, C.CategoryName, P.ModelYear, P.ListPrice
FROM Products P
JOIN Brands B
ON P.BrandID = B.BrandID
JOIN Categories C
ON P.CategoryID = C.CategoryID;

SELECT * FROM ProductView;

--2nd question
ALTER VIEW OrderDetailsView
AS
SELECT c.customerName, s.StoreName, st.StaffName
FROM Orders as o
JOIN Customers as c
ON o.CustomerID = c.CustomerID
JOIN Stores as s
ON o.StoreID = s.StoreID
JOIN Staff as st
ON o.StaffID = st.StaffID;

SELECT * FROM OrderDetailsView;

--3rd question
CREATE INDEX idx_products_brandid
ON Products(BrandID);

CREATE INDEX idx_products_categoryid
ON Products(CategoryID);

CREATE INDEX idx_orders_customerid
ON Orders(CustomerID);

CREATE INDEX idx_orders_storeid
ON Orders(StoreID);

