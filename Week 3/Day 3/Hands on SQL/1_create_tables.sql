CREATE DATABASE SalesDB;

USE SalesDB;

CREATE TABLE brands (
brand_id INT PRIMARY KEY IDENTITY(1, 1),
brand_name VARCHAR(100) NOT NULL);

CREATE Table categories (
category_id INT PRIMARY key IDENTITY(1, 1),
category_name VARCHAR(100) NOT NULL);


CREATE TABLE stores (
store_id INT PRIMARY KEY IDENTITY(1,1),
store_name VARCHAR(100) NOT NULL,
city VARCHAR(100)
);

CREATE TABLE customers (
customer_id INT PRIMARY KEY IDENTITY(1,1),
first_name VARCHAR(100),
last_name VARCHAR(100),
email VARCHAR(150)
);

CREATE TABLE products (
product_id INT PRIMARY KEY IDENTITY(1,1),
product_name VARCHAR(150) NOT NULL,
brand_id INT,
category_id INT,
price DECIMAL(10,2),
FOREIGN KEY (brand_id) REFERENCES brands(brand_id),
FOREIGN KEY (category_id) REFERENCES categories(category_id)
);

CREATE TABLE orders (
order_id INT PRIMARY KEY IDENTITY(1,1),
customer_id INT,
store_id INT,
order_date DATE,
status VARCHAR(50),
FOREIGN KEY (customer_id) REFERENCES customers(customer_id),
FOREIGN KEY (store_id) REFERENCES stores(store_id)
);

CREATE TABLE order_items (
order_item_id INT PRIMARY KEY IDENTITY(1,1),
order_id INT,
product_id INT,
quantity INT,
list_price DECIMAL(10,2),
FOREIGN KEY (order_id) REFERENCES orders(order_id),
FOREIGN KEY (product_id) REFERENCES products(product_id)
);

CREATE TABLE stocks (
store_id INT,
product_id INT,
quantity INT,
PRIMARY KEY (store_id, product_id),
FOREIGN KEY (store_id) REFERENCES stores(store_id),
FOREIGN KEY (product_id) REFERENCES products(product_id)
);

DROP TABLE order_items;
DROP TABLE stocks;
DROP TABLE orders;
DROP TABLE products;
DROP TABLE customers;
DROP TABLE stores;
DROP TABLE brands;
DROP TABLE categories;


