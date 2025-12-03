-- Fiyatı 100'den büyük eşit olan ürünleri listeleyelim

SELECT ProductName, UnitPrice
FROM Products
WHERE UnitPrice>=100