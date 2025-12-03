-- Her kategoride kaç ürün var? Ortalama fiyatları nedir?
-- En ucuz/pahalı ürün fiyatları nelerdi?

SELECT
	c.CategoryName AS [Kategori],
	count(p.ProductID) AS [Ürün Sayısı],
	avg(p.UnitPrice) AS [Ortalama Fiyat],
	min(p.UnitPrice) AS [En Düşük Fiyat],
	max(p.UnitPrice) AS [En Yüksek Fiyat]
FROM 
	Categories c INNER JOIN Products p
		ON p.CategoryID = c.CategoryID
GROUP BY c.CategoryName
ORDER BY [Ürün Sayısı] DESC
LIMIT 1
