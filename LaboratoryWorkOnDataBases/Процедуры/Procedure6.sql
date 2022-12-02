CREATE PROCEDURE [dbo].[Procedure6] @N INT
AS 
UPDATE Orders
SET Price = Price * @N;

SELECT Price FROM Orders;