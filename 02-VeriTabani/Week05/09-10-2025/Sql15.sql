-- Count, sum, avg, min, max

SELECT 
	count(*),
	sum(od.UnitPrice * od.Quantity*(1-od.Discount)) AS 'Toplam Ciro',
	avg(od.UnitPrice * od.Quantity*(1-od.Discount)) AS 'Ortalama'
FROM [Order Details] od