/*
SELECT *
FROM Customers
WHERE CompanyName = 'Que Del�cia'

SELECT *
FROM Orders
WHERE CustomerID = 'QUEDE'
*/

SELECT o.*
FROM Customers c, Orders o
WHERE c.CompanyName = 'Que Del�cia' AND
c.CustomerID = o.CustomerID

SELECT o.* FROM Customers c
INNER JOIN Orders o ON c.CustomerID = o.CustomerID
WHERE c.CompanyName = 'Que Del�cia'
