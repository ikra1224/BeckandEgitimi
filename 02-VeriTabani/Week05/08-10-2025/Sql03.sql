-- Sipariş tarihi belirli bir tarihten sonra olan siparişleri listeleyelim

SELECT OrderID, CustomerID, OrderDate
FROM Orders
WHERE OrderDate>='2023-01-01' AND CustomerID='ROMEY'