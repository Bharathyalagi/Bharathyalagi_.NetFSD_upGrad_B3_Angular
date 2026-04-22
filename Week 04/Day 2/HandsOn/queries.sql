--1st question 
CREATE TRIGGER trg_reduce_stock
ON order_items
AFTER INSERT
AS
BEGIN
IF EXISTS
( 
SELECT 1 
FROM inserted i
JOIN stocks s
ON i.product_id = s.product_id
WHERE s.quantity - i.quantity < 0
)
BEGIN
RAISERROR('Insufficient stock',16,1)
ROLLBACK TRANSACTION
RETURN
END

UPDATE s
SET s.quantity = s.quantity - i.quantity
FROM stocks s
JOIN inserted i ON s.product_id = i.product_id
END


BEGIN TRY
BEGIN TRANSACTION
DECLARE @orderid INT = 1
INSERT INTO orders
VALUES(@orderid,GETDATE(),1)

INSERT INTO order_items
VALUES
(1,@orderid,1,2,10000,0),
(2,@orderid,2,3,500,0),

COMMIT
END TRY
BEGIN CATCH
ROLLBACK
PRINT ERROR_MESSAGE()
END CATCH

SELECT * FROM stocks;
SELECT * FROM orders;
SELECT * FROM order_items;

--2nd question
BEGIN TRY
BEGIN TRANSACTION
DECLARE @cancelorder INT = 1
SAVE TRANSACTION before_restore

UPDATE s
SET s.quantity = s.quantity + oi.quantity
FROM stocks s
JOIN order_items oi
ON s.product_id = oi.product_id
WHERE oi.order_id = @cancelorder

IF @@ERROR <> 0
BEGIN
ROLLBACK TRANSACTION before_restore
END

UPDATE orders
SET order_status = 3
WHERE order_id = @cancelorder

COMMIT
END TRY

BEGIN CATCH
ROLLBACK
PRINT ERROR_MESSAGE()
END CATCH

SELECT * FROM stocks;
SELECT * FROM orders;

/* KEEP IN MIND
status 1: pending
status 2 : processing
status 3: rejected
status 4: success */
