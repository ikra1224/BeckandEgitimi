SELECT
	c.Country, c.City, count(*) AS [Müşteri Sayısı]
FROM Customers c
GROUP BY c.Country, c.City
ORDER BY c.Country, c.City