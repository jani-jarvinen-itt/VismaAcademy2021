/*
SELECT *
FROM Customers
WHERE CompanyName = 'Que Delícia'

SELECT *
FROM Orders
WHERE CustomerID = 'QUEDE'
*/

SELECT o.*
FROM Customers c, Orders o
WHERE c.CompanyName = 'Que Delícia' AND
c.CustomerID = o.CustomerID

SELECT o.* FROM Customers c
INNER JOIN Orders o ON c.CustomerID = o.CustomerID
WHERE c.CompanyName = 'Que Delícia'
