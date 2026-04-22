CREATE DATABASE AutoDB;
USE AutoDB;
CREATE TABLE categories(
category_id INT,      --categories table
category_name VARCHAR(50));

CREATE TABLE products(
product_id INT,
product_name VARCHAR(50),
model_year INT,       -- products table
list_price INT,
category_id INT);

CREATE TABLE customers(
customer_id INT,
first_name VARCHAR(50),      --customers table
last_name VARCHAR(50));

CREATE TABLE orders(
order_id INT,
customer_id INT,
order_status INT,        --orders table
order_date DATE,
required_date DATE,
shipped_date DATE);

CREATE TABLE order_items(
order_id INT,
product_id INT,
quantity INT,          --order_items table
list_price INT,
discount INT);

CREATE TABLE stores(
store_id INT,         --stores table
store_name VARCHAR(50));

CREATE TABLE stocks(
store_id INT,
product_id INT,           --stocks table
quantity INT
);



INSERT INTO categories VALUES(1,'Bike'), (2, 'car');

INSERT INTO products VALUES
(1,'Off road Bike',2017,5000,1),(2,'On Road Bike',2018,8000,1),
(3,'Electric Car',2020,20000,2);

INSERT INTO customers VALUES (1,'Bharath','Yalagi'),(2,'Bhuvan','Yalagi'), (3,'Sushmita','M');

INSERT INTO orders VALUES(1,1,1,'2024-01-01','2024-01-05','2024-01-03'),
(2,2,1,'2024-02-01','2024-02-05','2024-02-06');

INSERT INTO order_items VALUES(1,1,2,5000,500), (2,3,1,20000,1000);

INSERT INTO stores VALUES(1,'Main Store'), (2,'City Store');

INSERT INTO stocks VALUES(1,1,10),(1,3,0),(2,2,5);

SELECT * FROM customers;