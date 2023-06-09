-- TASK 1
--SELECT FirstName, LastName
--FROM Authors AS A JOIN 
--Books AS B ON B.Id_Author=A.Id
--GROUP BY FirstName, LastName
--HAVING AVG(Pages)>600

-- TASK 2
--SELECT P.[Name]
--FROM Press AS P JOIN 
--Books AS B ON B.Id_Press=P.Id
--GROUP BY P.[Name]
--HAVING SUM(Pages)>700

-- TASK 3
--SELECT S.FirstName, S.LastName, B.Name
--FROM Students AS S, Books AS B, S_Cards AS SC
--WHERE S.Id=SC.Id_Student AND B.Id=SC.Id_Book
--UNION
--SELECT T.FirstName, T.LastName, B.Name
--FROM Teachers AS T, Books AS B, T_Cards AS TC
--WHERE T.Id=TC.Id_Teacher AND B.Id=TC.Id_Book


-- TASK 4
--SELECT TOP 1 A.FirstName, A.LastName, COUNT(SC.Id) AS [Number of books]
--FROM Authors AS A JOIN Books AS B ON A.Id = B.Id_Author
--JOIN S_Cards AS SC ON B.Id = SC.Id_Book
--GROUP BY A.FirstName, A.LastName
--ORDER BY COUNT(SC.Id) DESC;

-- TASK 5
--SELECT TOP 1 A.FirstName, A.LastName, COUNT(TC.Id) AS [Number of books]
--FROM Authors AS A JOIN Books AS B ON A.Id = B.Id_Author
--JOIN T_Cards AS TC ON B.Id = TC.Id_Book
--GROUP BY A.FirstName, A.LastName
--ORDER BY COUNT(TC.Id) DESC;

-- TASK 6 ???
--SELECT TOP 1  Pop.[Name]
--FROM 
--((SELECT T.Name, SC.Id_Book
--FROM Themes AS T JOIN Books AS B ON T.Id = B.Id_Themes
--JOIN S_Cards AS SC ON B.Id= SC.Id_Book)
--UNION ALL
--(SELECT T.Name, TC.Id_Book
--FROM Themes AS T JOIN Books AS B ON T.Id = B.Id_Themes
--JOIN T_Cards AS TC ON B.Id= TC.Id_Book)) AS Pop
--GROUP BY Pop.[Name]
--ORDER BY COUNT(Pop.Id_Book) DESC

-- TASK 7 
--SELECT 'Students' AS Total,  COUNT(*) AS 'Count' 
--FROM Students AS S, Books AS B, S_Cards AS SC
--WHERE S.Id=SC.Id_Student AND B.Id=SC.Id_Book
--UNION
--SELECT 'Teachers', COUNT(*) 
--FROM Teachers AS T, Books AS B, T_Cards AS TC
--WHERE T.Id=TC.Id_Teacher AND B.Id=TC.Id_Book


--TASK 8  ???
--(SELECT TOP (1) F.[Name], COUNT(B.Id) AS [Number of books]
--FROM Faculties AS F 
--JOIN Groups AS G ON F.Id=G.Id_Faculty 
--JOIN Students AS S ON S.Id_Group=G.Id 
--JOIN S_Cards AS SC ON SC.Id_Student=S.Id 
--JOIN Books AS B ON SC.Id_Book = B.Id
--GROUP BY F.[Name]
--UNION ALL 
--SELECT TOP (1) D.[Name],COUNT(B.Id) AS [Number of books]
--FROM Departments AS D 
--JOIN Teachers AS T ON D.Id=T.Id_Dep 
--JOIN T_Cards AS TC ON TC.Id_Teacher = T.Id 
--JOIN Books AS B ON TC.Id_Book = B.Id
--GROUP BY D.[Name])
--ORDER BY COUNT(B.Id)

--TASK 9
--SELECT TOP 1 A.FirstName, A.LastName
--FROM Authors AS A JOIN Books AS B ON A.Id = B.Id_Author
--JOIN S_Cards AS SC ON B.Id = SC.Id_Book
--JOIN T_Cards AS TC ON B.Id=TC.Id_Book
--GROUP BY A.FirstName, A.LastName
--ORDER BY COUNT(*) DESC

--TASK 10 
--SELECT TOP 1 B.Name
--FROM Books AS B JOIN S_Cards AS SC ON B.Id=SC.Id_Book
--JOIN T_Cards AS TC ON B.Id=TC.Id_Book
--GROUP BY B.Name
--ORDER BY COUNT(*) DESC

--TASK 11
--SELECT S.FirstName, S.LastName, F.Name
--FROM Students AS S JOIN Groups AS G ON S.Id_Group=G.Id
--JOIN Faculties AS F ON F.Id=G.Id_Faculty
--WHERE F.Name  LIKE (N'%Design%')
--UNION
--SELECT T.FirstName, T.LastName, D.Name
--FROM Teachers AS T JOIN Departments AS D ON T.Id_Dep=D.Id
--WHERE D.Name  LIKE (N'%Design%')