-- 1st
SELECT c.customer_id, c.first_name, c.last_name, COUNT(o.order_id) AS total_orders
FROM customers as c
LEFT JOIN orders as o
ON c.customer_id = o.customer_id
GROUP BY c.customer_id, c.first_name, c.last_name;

SELECT * FROM customers, 
SELECT * from orders;

--2nd
SELECT cat.category_name, COUNT(p.product_id) AS total_products
FROM categories as  cat
LEFT JOIN products as p ON cat.category_id = p.category_id
GROUP BY cat.category_name;

SELECT * from categories
SELECT * from products;

--3rd
SELECT s.store_name, SUM(oi.quantity * oi.list_price) AS total_revenue
FROM stores as s
JOIN orders as o 
ON s.store_id = o.store_id
JOIN order_items as oi 
ON o.order_id = oi.order_id
GROUP BY s.store_name;

--4th
SELECT p.product_name
FROM products as p
LEFT JOIN order_items as oi 
ON p.product_id = oi.product_id
WHERE oi.product_id IS NULL;

SELECT * FROM products;
SELECT * FROM order_items;