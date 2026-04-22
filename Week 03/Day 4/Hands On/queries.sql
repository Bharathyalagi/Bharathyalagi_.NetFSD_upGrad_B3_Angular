--1st question 
SELECT product_name + ' (' + CAST(model_year AS VARCHAR) + ')' AS product, list_price,
list_price - (SELECT AVG(list_price)
FROM products p2
WHERE p2.category_id = p1.category_id
) AS price_difference
FROM products p1
WHERE list_price >
(SELECT AVG(list_price)
FROM products p2
WHERE p2.category_id = p1.category_id );

--2nd question
SELECT first_name + ' ' + last_name AS full_name,
CASE 
WHEN total > 10000 THEN 'Premium'
WHEN total BETWEEN 5000 AND 10000 THEN 'Regular'
ELSE 'Basic'
END AS customer_type
FROM
(
SELECT c.customer_id, first_name, last_name,
SUM(quantity * list_price - discount) AS total
FROM customers c
JOIN orders o ON c.customer_id = o.customer_id
JOIN order_items oi ON o.order_id = oi.order_id
GROUP BY c.customer_id, first_name, last_name
) t
UNION
SELECT first_name + ' ' + last_name,'No Orders'
FROM customers
WHERE customer_id NOT IN (SELECT customer_id FROM orders);

--3rd question
SELECT s.store_name, p.product_name,
SUM(oi.quantity) AS total_quantity_sold
FROM stores s
JOIN stocks st ON s.store_id = st.store_id
JOIN products p ON st.product_id = p.product_id
JOIN order_items oi ON p.product_id = oi.product_id
WHERE st.quantity = 0
GROUP BY s.store_name, p.product_name;

--4th question
SELECT order_id, DATEDIFF(day, order_date, shipped_date) AS delay_days,
CASE WHEN shipped_date > required_date THEN 'Delayed'
ELSE 'On Time'
END AS order_status
FROM orders;
