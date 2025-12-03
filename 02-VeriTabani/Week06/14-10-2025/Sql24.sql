-- UPDATE komutu ASLA WHERE olmadan kullanılmamalıdır!

-- 80 id'li Organic Tofu3 ürünümüzün QuantityPerUnit kolonuna bilgi gireceğiz yani
-- ilgili kaydı güncelleyeceğiz

UPDATE Products
SET QuantityPerUnit = '12 - 550 ml bottles' 
WHERE ProductID=80