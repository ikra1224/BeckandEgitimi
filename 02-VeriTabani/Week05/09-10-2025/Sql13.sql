-- Hiç ürünü olmayan kategorileri listele
SELECT c.CategoryName, p.ProductName
FROM Categories c LEFT JOIN Products p ON c.CategoryID=p.CategoryID
WHERE p.CategoryID is NULL

