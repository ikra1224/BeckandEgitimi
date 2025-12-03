-- Fiyatı 20 ile 50 arasındakileri göster
SELECT ProductName, UnitPrice
FROM Products
--WHERE UnitPrice>=20 AND UnitPrice<=50
WHERE UnitPrice BETWEEN 20 AND 50
ORDER BY UnitPrice