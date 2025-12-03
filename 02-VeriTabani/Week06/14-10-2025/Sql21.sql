SELECT *
FROM Products p
WHERE p.UnitPrice > (SELECT avg(UnitPrice) FROM Products)