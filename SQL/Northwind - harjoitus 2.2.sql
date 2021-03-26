SELECT ProductName, UnitPrice, UnitsInStock, UnitPrice*UnitsInStock
FROM Products
ORDER BY UnitPrice*UnitsInStock DESC

SELECT SUM(UnitPrice*UnitsInStock)
FROM Products
