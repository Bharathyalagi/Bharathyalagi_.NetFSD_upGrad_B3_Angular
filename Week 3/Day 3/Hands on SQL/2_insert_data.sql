INSERT INTO brands (brand_name)
VALUES ('Nike'),('Adidas'),('Puma');

INSERT INTO categories (category_name) VALUES
('Shoes'),('Clothing'),('Accessories');


INSERT INTO stores (store_name, city) VALUES
('Central Store', 'Bangalore'),('City Mall Store', 'Mumbai');

SELECT * FROM stores;

INSERT INTO customers (first_name, last_name, email) VALUES
('abc','xyz', 'abc@gmail.com'),('Bhuvan', 'yalagi', 'bhuvan.com'),('sushmita', 'm', 'sushmita@gmail.com'),
('cristiano', 'ronaldo', 'ronaldo@gmail.com');

SELECT * FROM customers;
UPDATE customers SET first_name = 'Bharath',last_name = 'yalagi' WHERE customer_id = 1;

INSERT INTO products (product_name, brand_id, category_id, price) VALUES
('Running Shoes', 1, 1, 5000),('Sports T-Shirt', 2, 2, 1500),('Cap', 3, 3, 800),('Sneakers', 1, 1, 4500),('Jacket', 2, 2, 3500);


INSERT INTO orders (customer_id, store_id, order_date, status) VALUES
(1, 1, '2024-01-10', 'Completed'),(2, 1, '2024-01-12', 'Completed'),
(3, 2, '2024-01-15', 'Pending'),(1, 2, '2024-02-01', 'Completed'),
(4, 1, '2024-02-05', 'Cancelled');

INSERT INTO order_items (order_id, product_id, quantity, list_price) VALUES
(1, 1, 2, 5000),(1, 3, 1, 800),(2, 2, 3, 1500),(3, 4, 1, 4500),(4, 5, 2, 3500);

INSERT INTO stocks (store_id, product_id, quantity) VALUES
(1, 1, 50),(1, 2, 40),(1, 3, 30),(2, 4, 20),
(2, 5, 15);

TRUNCATE Table customers;
SELECT * FROM stocks;