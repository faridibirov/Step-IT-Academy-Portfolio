--TASK 4
--SELECT DISTINCT Topic, Category
--FROM Books_En
--WHERE Category IS NULL

--TASK 5
--SELECT TOP(1) [Name], Price, Pages, Publisher
--FROM Books_En
--WHERE Publisher LIKE N'%BHV%'
--ORDER BY Price DESC

--SELECT TOP(1) [Name], Price, Pages, Publisher
--FROM (SELECT [Name], Price, Pages, Publisher 
--	FROM Books_En
--	WHERE Publisher LIKE N'%BHV%') AS BHV
--ORDER BY Price DESC

--TASK 6
--SELECT TOP(1)  Publisher, SUM(Pages) AS [Sum of pages]
--FROM Books_En
--GROUP BY Publisher
--ORDER BY SUM(Pages) DESC


--SELECT TOP(1)   Publisher, SUM(Pages) AS [Sum of pages]
--FROM  ( SELECT Publisher, Pages 
--		FROM Books_En) AS pub
--GROUP BY Publisher
--ORDER BY [Sum of pages] DESC


--TASK 7
--SELECT TOP(1)  Publisher, COUNT(*) AS [Number of books]
--FROM Books_En
--WHERE Topic=N'Programming'
--GROUP BY Publisher
--ORDER BY COUNT(*) DESC

--SELECT TOP(1)  Publisher, COUNT(*) AS [Number of books]
--FROM (SELECT  Publisher
--	FROM Books_En
--	WHERE Topic=N'Programming') as pub
--GROUP BY Publisher
--ORDER BY COUNT(*) DESC

-- TASK 8
--SELECT Topic, COUNT(*) AS [Number of books]
--FROM Books_En
--GROUP BY Topic
--HAVING Topic IS NOT NULL

-- TASK 9
--SELECT  Topic, MIN(Price) AS [Minumum Price]
--FROM (Select Topic, [Name], Price
--	  FROM Books_En
--	  WHERE Topic IN (N'Programming', N'Database client-server data', N'Multimedia' ) ) AS minprice
--GROUP BY Topic


-- TASK 10
--SELECT DISTINCT  Publisher, MIN([Date]) AS [Date]
--FROM Books_En
--WHERE Publisher IS NOT NULL AND [Date] IS NOT NULL
--GROUP BY  Publisher


-- TASK 11
--SELECT DISTINCT Publisher, MAX([Date]) AS [Date], COUNT(*) AS [Number of new books]
--FROM Books_En
--WHERE [Date] IS NOT NULL
--GROUP BY Publisher


--TASK 12 
--SELECT TOP(1) Publisher, MAX([Date]) AS [Date], COUNT(*) AS [Number of books]
--FROM Books_En
--GROUP BY Publisher
--ORDER BY COUNT(*) DESC

--SELECT TOP(1) Publisher, MAX([Date]) AS [Date], COUNT(*) AS [Number of books]
--FROM (SELECT Publisher, [Date]
--	  FROM Books_En) AS newbooks
--GROUP BY Publisher
--ORDER BY COUNT(*) DESC


-- TASK 13 
--SELECT DISTINCT Topic, (SUM(Price)*COUNT(*)) * 100 / (SELECT COUNT(*) * SUM(Price)FROM Books_En) AS [%]
--FROM Books_En
--WHERE Topic IS NOT NULL
--GROUP By Topic

--TASK 14 
--SELECT Publisher, AVG(Price) AS [Average Price]
--FROM Books_En
--WHERE [Date]>'1999-01-03' AND [Date]<'1999-31-05'
--GROUP BY Publisher

--TASK 15
--SELECT TOP(1) [Name], Pressrun
--FROM Books_En
--WHERE Pressrun IS NOT NULL
--ORDER BY Pressrun DESC

--SELECT TOP(1) [Name], Pressrun
--FROM Books_En
--WHERE Pressrun = (SELECT MAX(Pressrun) FROM Books_En)

--TASK 16 
--SELECT Publisher, Pressrun
--FROM Books_En
--GROUP BY Publisher, Pressrun
--HAVING COUNT(*) > ((SELECT COUNT(*) FROM Books_En)*0.05)

--TASK 17
--SELECT [Name], Code
--FROM Books_En
--WHERE Code LIKE N'%[7]%[7]%' AND Code NOT LIKE N'%[7]%[7]%[7]%'

--TASK 18
--SELECT [Name], Publisher
--FROM Books_En
--WHERE Publisher LIKE N'%[l]%[a]%[k]%'

--TASK 19
--SELECT [Name], Pages
--FROM Books_En
--WHERE [Name] NOT LIKE N'%[a-z]%' AND Pages%2=0

--TASK 20
--SELECT COUNT(*) AS [Number of books]
--FROM Books_En
--WHERE [Date] IS NULL