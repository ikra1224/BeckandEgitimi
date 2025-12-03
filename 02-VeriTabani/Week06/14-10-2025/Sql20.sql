-- Toplam satışı 50.000.000'dan fazla olan çalışanları göster.

SELECT
	e.FirstName || ' ' || e.LastName as [Çalışan],
	sum(od.UnitPrice * od.Quantity * (1-od.Discount)) as [Tutar]
FROM Employees e INNER JOIN Orders o ON e.EmployeeID=o.EmployeeID
	INNER JOIN [Order Details] od ON o.OrderID=od.OrderID
GROUP BY [Çalışan]
HAVING sum(od.UnitPrice * od.Quantity * (1-od.Discount))>=50000000
ORDER BY [Tutar] DESC