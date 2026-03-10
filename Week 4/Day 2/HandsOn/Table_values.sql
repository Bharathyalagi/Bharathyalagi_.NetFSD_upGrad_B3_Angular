CREATE DATABASE RetailDB;
USE RetailDB;

CREATE TABLE products
(
product_id INT PRIMARY KEY,
product_name VARCHAR(100)          --products
)

CREATE TABLE stocks
(
product_id INT PRIMARY KEY,
quantity INT,                --stocks
FOREIGN KEY(product_id) REFERENCES products(product_id)
)

CREATE TABLE orders
(
order_id INT PRIMARY KEY,
order_date DATE,                 --orders
order_status INT
)

CREATE TABLE order_items
(
order_item_id INT PRIMARY KEY,
order_id INT,
product_id INT,
quantity INT,                 --order_items
list_price DECIMAL(10,2),
discount DECIMAL(5,2),
FOREIGN KEY(order_id) REFERENCES orders(order_id),
FOREIGN KEY(product_id) REFERENCES products(product_id)
)


--values adding
INSERT INTO products VALUES
(1,'Bike'),
(2,'Helmet'),
(3,'Gloves')

INSERT INTO stocks VALUES
(1,20),
(2,50),
(3,40)

SELECT * FROM products;
SELECT * FROM stocks;