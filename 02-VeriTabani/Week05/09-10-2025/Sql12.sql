-- Hiç sipariş vermemiş müşterileri listele
SELECT
	c.CompanyName,
	o.OrderID
FROM Customers c LEFT JOIN Orders o ON c.CustomerID=o.CustomerID
WHERE o.OrderID is NULL
