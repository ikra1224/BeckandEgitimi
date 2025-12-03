-- Hangi çalışan toplam ne kadarlık satış yapmış? 

SELECT 
	e.FirstName || ' ' || e.LastName AS Çalışan,
	sum(od.UnitPrice * od.Quantity * (1-od.Discount)) AS Tutar
FROM 
	Employees e INNER JOIN Orders o ON e.EmployeeID=o.EmployeeID
		INNER JOIN [Order Details] od ON o.OrderID=od.OrderID
--WHERE FROM'dan hemen sonra yazılır.
GROUP BY Çalışan 
ORDER BY Tutar DESC