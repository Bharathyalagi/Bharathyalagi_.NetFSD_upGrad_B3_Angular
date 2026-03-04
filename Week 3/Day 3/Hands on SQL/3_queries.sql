-- 1st
SELECT c.first_name, c.last_name, o.order_id, o.order_date, o.status
FROM customers as c
inner JOIN orders as o
ON c.customer_id = o.customer_id
WHERE o.status = 'pending' 
OR o.status = 'completed'
ORDER BY o.order_date DESC;


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