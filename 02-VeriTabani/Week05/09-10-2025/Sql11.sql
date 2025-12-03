--Hangi çalışan, hangi müşterinin siparişini, hangi kargo kargo firmasıyla göndermiş?
--     Çalışan                          Müşteri                          Kargo Şirketi

SELECT 
	e.FirstName || ' ' || e.LastName AS [Çalışan],
	c.CompanyName AS [Müşteri],
	o.ShipName AS [Kargo Şirketi]
FROM 
	Orders o 
	INNER JOIN Customers c ON o.CustomerID=c.CustomerID
	INNER JOIN Employees e ON o.EmployeeID=e.EmployeeID
WHERE c.Country='Germany'