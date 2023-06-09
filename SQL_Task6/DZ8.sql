--SP TASK 1

--CREATE PROCEDURE Factorial
--@num  AS  int OUTPUT
--AS
--BEGIN
--DECLARE @factorial AS  int = 1
--IF @num > 0
--    WHILE @num > 0
--        BEGIN
--            SET @factorial = @factorial*@num
--            SET @num = @num - 1
--        END
-- ELSE
-- PRINT '‘акториал отрицательного числа не существует'

--SELECT @factorial AS Factorial
--END

--DECLARE  @number AS INT = 5
--EXEC Factorial  @number OUTPUT

--------------------------------------------------------

--SP TASK 2

--CREATE PROCEDURE LaizyStudents
--@count_students AS int OUTPUT
--AS
--BEGIN
--	SELECT S.FirstName, S.LastName
--	FROM Students AS S
--	LEFT JOIN S_Cards AS SC
--	ON S.Id = SC.Id_Student
--	WHERE SC.Id_Student IS NULL
--	SET @count_students = @@ROWCOUNT
--END

--DECLARE @count_st AS int
--EXEC LaizyStudents @count_st OUTPUT

--SELECT @count_st AS [Laizy students count]

-----------------------------------------------------

--UDF TASK 1
--CREATE FUNCTION BookList(@press_id AS int)
--RETURNS table
--AS
--RETURN(
--	SELECT B.[Name] AS Book, MIN(Pages) AS Pages 
--	FROM Books AS B
--	WHERE Pages<= (SELECT MIN(Pages) FROM Books WHERE Id_Press=@press_id ) AND Id_Press=@press_id
--	GROUP BY [Name]
--) 

--SELECT *
--FROM BookList(2)

-----------------------------------------------------


--UDF TASK 2
--CREATE FUNCTION AveragePages(@num AS int)
--RETURNS table
--AS
--RETURN(
--	SELECT DISTINCT P.Name, AVG(Pages) AS AveragePages
--	FROM Books AS B
--	JOIN Press AS P
--	ON B.Id_Press=P.Id
--	GROUP BY P.[Name]
--	HAVING AVG(Pages)>@num
--) 

--SELECT *
--FROM AveragePages (300)

-----------------------------------------------------


--UDF TASK 3
--CREATE FUNCTION SumPages(@press_id AS int)
--RETURNS int
--AS
--BEGIN
--	DECLARE @sum AS int=0
--	SELECT @sum=SUM(Pages)
--	FROM Books AS B
--	WHERE  Id_Press=@press_id

--	RETURN @sum
--END 

--DECLARE @sum AS int
--EXEC @sum = SumPages 2
--SELECT @sum AS SumPages