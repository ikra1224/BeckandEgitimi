-- Almanya, Fransa ve İngiltere'deki Müşteriler
SELECT CompanyName, Country
FROM Customers
-- WHERE Country='Germany' OR Country='France' OR Country='UK'
WHERE Country IN ('Germany','France','UK')