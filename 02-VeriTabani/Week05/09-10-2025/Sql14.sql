-- Hiç satışı yapılmayan kategorileri göster
SELECT
	c.CategoryName, 
	o.OrderID
FROM 
	Categories c 
		LEFT JOIN Products p ON c.CategoryID=p.CategoryID
		LEFT JOIN  [Order Details] od ON od.ProductID=p.ProductID
		LEFT JOIN Orders o ON o.OrderID=od.OrderID 
WHERE o.OrderId is NULL