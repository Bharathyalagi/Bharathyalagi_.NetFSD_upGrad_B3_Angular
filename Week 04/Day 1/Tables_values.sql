CREATE DATABASE Triggers;
USE Triggers;


CREATE TABLE stores
(
store_id int primary key,
store_name varchar(100)
)

CREATE TABLE products
(
product_id int primary key,
product_name varchar(100),
price decimal(10,2)
)

CREATE TABLE stocks
(
product_id int,
store_id int,
quantity int,
primary key(product_id,store_id)
)

CREATE TABLE orders
(
order_id int primary key,
store_id int,
order_date date,
shipped_date date,
order_status int
)

CREATE TABLE order_items
(
order_item_id int primary key,
order_id int,
product_id int,
quantity int,
list_price decimal(10,2),
discount decimal(5,2)
)

INSERT INTO stores VALUES (1,'Central Store')
INSERT INTO stores VALUES (2,'City Store')

INSERT INTO products VALUES (1,'Laptop',80000)
INSERT INTO products VALUES (2,'Phone',30000)
INSERT INTO products VALUES (3,'Tablet',20000)
INSERT INTO products VALUES (4,'Monitor',15000)
INSERT INTO products VALUES (5,'Keyboard',2000)
INSERT INTO products VALUES (6,'Mouse',1000)

INSERT INTO stocks VALUES (1,1,20)
INSERT INTO stocks VALUES (2,1,30)
INSERT INTO stocks VALUES (3,1,15)
INSERT INTO stocks VALUES (4,1,10)
INSERT INTO stocks VALUES (5,1,50)
INSERT INTO stocks VALUES (6,1,60)

INSERT INTO orders VALUES (101,1,'2025-01-01','2025-01-03',4)
INSERT INTO orders VALUES (102,1,'2025-01-05',NULL,1)
INSERT INTO orders VALUES (103,2,'2025-01-10','2025-01-12',4)

INSERT INTO order_items VALUES (1,101,1,1,80000,0.05)
INSERT INTO order_items VALUES (2,101,5,2,2000,0)
INSERT INTO order_items VALUES (3,103,2,1,30000,0.10)
INSERT INTO order_items VALUES (4,103,6,3,1000,0)
