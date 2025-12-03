-- HAVING, GROUP BY'ın WHERE'idir.
-- 10'dan fazla müşterisi olan ülkeler hangileridir?
SELECT 
	Country as [Ülke],
	count(*) as [Müşteri Sayısı]
FROM Customers c
WHERE c.Country is not NULL
GROUP BY Country
HAVING count(*) > 10
ORDER BY [Müşteri Sayısı] DESC