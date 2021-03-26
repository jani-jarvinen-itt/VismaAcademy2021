/*SELECT *
FROM Products
WHERE ProductName LIKE '%tofu%'

SELECT SUM(UnitPrice*Quantity*(1-Discount))
FROM [Order Details]
WHERE ProductID IN (14, 74)
-- WHERE ProductID = 14 OR ProductID = 74
*/

-- esimerkki alikyselystä (sub-query)
SELECT SUM(UnitPrice*Quantity*(1-Discount))
FROM [Order Details]
WHERE ProductID IN (
	SELECT ProductID
	FROM Products
	WHERE ProductName LIKE '%tofu%')
