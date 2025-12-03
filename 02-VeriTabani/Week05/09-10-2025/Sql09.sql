--JOIN
-- INNER JOIN: Birleştirilecek olan her iki tablodaki eşleşen kayıtları getirir.
--Hangi ürün hangi kategoride?
SELECT p.ProductName AS 'Ürün Adı', c.CategoryName AS [Kategori Adı]
FROM Products p INNER JOIN Categories c ON p.CategoryID=c.CategoryID 