-- Таблица с продуктами [Products] : ProductID,Name
-- Таблица категорий	[Categories]: СategoryID,Name
-- Таблица связывающая  [Products_Categories]: ProductID,СategoryID

USE [Shop]

SELECT 
p.Name					as	[Имя продукта], 
c.Name					as	[Имя категории]
FROM		[Products]				p									
LEFT JOIN	[Products_Categories]	pc	on p.ProductID=pc.ProductID 	
LEFT JOIN	[Categories]			c	on pc.СategoryID = c.СategoryID 
ORDER BY p.Name
