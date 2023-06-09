

-- TASK 1
--SELECT BusinessEntityID, FirstName, LastName, CountryRegionName, StateProvinceName, City 
--FROM Employees
--WHERE CountryRegionName=N'United States'

-- TASK 2
--SELECT JobTitle, COUNT(JobTitle) AS [Number of employees]
--FROM Employees
--GROUP BY JobTitle

-- TASK 3
--SELECT FirstName, COUNT(FirstName) AS [Number of employees]
--FROM Employees
--GROUP BY FirstName

-- TASK 4
--SELECT TOP(1) FirstName, COUNT(FirstName) AS [Number of employees]
--FROM Employees
--GROUP BY FirstName 
--Order BY [Number of employees] DESC

-- TASK 5
--SELECT TOP(1) FirstName, COUNT(FirstName) AS [Number of employees]
--FROM Employees
--GROUP BY FirstName 
--Order BY [Number of employees] 

-- TASK 6
--SELECT TOP(5) City, COUNT(City) AS [Number of employees]
--FROM Employees
--GROUP BY City 
--Order BY [Number of employees] DESC

-- TASK 7 
--SELECT  TOP(5) City,  COUNT(DISTINCT JobTitle) AS [Number of employees] 
--FROM Employees
--GROUP BY City 
--Order BY [Number of employees] DESC

-- TASK 8 
--SELECT  EmailAddress, StartDate
--FROM Employees
--WHERE StartDate>'2012-01-01'

-- TASK 9
--SELECT  YEAR(StartDate) AS [Year], COUNT(*) AS [Number of employees]
--FROM Employees
--GROUP BY YEAR(StartDate)

-- TASK 10
--SELECT  YEAR(StartDate) AS [Year], CountryRegionName,  COUNT(*) AS [Number of employees]
--FROM Employees
--GROUP BY YEAR(StartDate), CountryRegionName
--ORDER BY YEAR(StartDate)

-- TASK 11 
--UPDATE Employees
--SET EndDate=History.EndDate
--FROM History
--WHERE History.BusinessEntityID=Employees.BusinessEntityID

-- TASK 12
--SELECT  YEAR(EndDate) AS [Year],  COUNT(*) AS [Number of employees]
--FROM Employees
--WHERE EndDate IS NOT NULL
--GROUP BY YEAR(EndDate)
--ORDER BY YEAR(EndDate)

--TASK 13
--SELECT COUNT(*) AS [Number of employees]
--FROM Employees
--WHERE DATEDIFF(MONTH, StartDate, EndDate)<12
