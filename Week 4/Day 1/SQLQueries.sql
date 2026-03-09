--1st question
CREATE FUNCTION fn_total_after_discount
(
@price decimal(10,2),
@qty int,
@disc decimal(5,2)
)
RETURNS decimal(12,2)
AS
BEGIN
DECLARE @result decimal(12,2)
SET @result = (@price * @qty) - (@price * @qty * ISNULL(@disc,0))
RETURN @result
END

CREATE FUNCTION fn_top_products()
RETURNS TABLE
AS
RETURN
(
SELECT TOP 5 p.product_id,p.product_name,SUM(oi.quantity) total_sold
FROM order_items oi
JOIN products p ON oi.product_id=p.product_id
GROUP BY p.product_id,p.product_name
ORDER BY total_sold DESC
)

CREATE PROCEDURE usp_total_sales_per_store
@store int
AS
BEGIN
SELECT s.store_name,SUM((oi.list_price*oi.quantity)-(oi.list_price*oi.quantity*ISNULL(oi.discount,0))) total_sales
FROM orders o
JOIN order_items oi ON o.order_id=oi.order_id
JOIN stores s ON o.store_id=s.store_id
WHERE o.store_id=@store
GROUP BY s.store_name
END

CREATE PROCEDURE usp_orders_by_date
@startdate date,
@enddate date
AS
BEGIN
SELECT *
FROM orders
WHERE order_date BETWEEN @startdate AND @enddate
END

--2nd question
CREATE TRIGGER trg_stock_update
ON order_items
AFTER INSERT
AS
BEGIN
BEGIN TRY

IF EXISTS
(
SELECT 1
FROM inserted i
JOIN stocks s ON i.product_id=s.product_id
WHERE s.quantity - i.quantity < 0
)
BEGIN
RAISERROR('Stock not available',16,1)
ROLLBACK TRANSACTION
RETURN
END

UPDATE s
SET s.quantity = s.quantity - i.quantity
FROM stocks s
JOIN inserted i ON s.product_id=i.product_id

END TRY
BEGIN CATCH
ROLLBACK TRANSACTION
THROW
END CATCH
END

--3rd question
CREATE TRIGGER trg_validate_order_status
ON orders
AFTER UPDATE
AS
BEGIN
BEGIN TRY

IF EXISTS
(
SELECT 1
FROM inserted
WHERE order_status=4 AND shipped_date IS NULL
)
BEGIN
RAISERROR('Completed order must have shipped date',16,1)
ROLLBACK TRANSACTION
RETURN
END

END TRY
BEGIN CATCH
ROLLBACK TRANSACTION
THROW
END CATCH
END

--4th question
CREATE TABLE #store_revenue
(
store_id int,
revenue decimal(12,2)
)

BEGIN TRY
BEGIN TRANSACTION

DECLARE @oid int
DECLARE @sid int
DECLARE @rev decimal(12,2)

DECLARE cur_orders CURSOR FOR
SELECT order_id,store_id
FROM orders
WHERE order_status=4

OPEN cur_orders

FETCH NEXT FROM cur_orders INTO @oid,@sid

WHILE @@FETCH_STATUS=0
BEGIN

SELECT @rev=SUM((list_price*quantity)-(list_price*quantity*ISNULL(discount,0)))
FROM order_items
WHERE order_id=@oid

INSERT INTO #store_revenue VALUES(@sid,@rev)

FETCH NEXT FROM cur_orders INTO @oid,@sid
END

CLOSE cur_orders
DEALLOCATE cur_orders

SELECT store_id,SUM(revenue) total_revenue
FROM #store_revenue
GROUP BY store_id

COMMIT TRANSACTION
END TRY
BEGIN CATCH
ROLLBACK TRANSACTION
END CATCH