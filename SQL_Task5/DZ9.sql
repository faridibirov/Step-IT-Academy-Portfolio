-- TASK 1
--CREATE DATABASE Lecturers

--GO

--USE Lecturers

--CREATE TABLE POST
--(
--	Id int PRIMARY KEY IDENTITY(1,1),
--	[Name] nvarchar(20)
--	)

--CREATE TABLE TEACHER
--(
--	Id int PRIMARY KEY IDENTITY(1,1),
--	[Name] nvarchar(15),
--	Code char(10),
--	IdPost INT REFERENCES POST (Id),
--	Tel char(7),
--	Salary int,
--	Rise numeric(6,2),
--	HireDate datetime
--	)

--TASK2 
--ALTER TABLE Teacher
--DROP FK__TEACHER__IdPost__398D8EEE
--DROP TABLE POST

--TASK 3
--ALTER TABLE Teacher
--DROP COLUMN IdPost

--TASK 4
--ALTER TABLE Teacher
--ADD CONSTRAINT HIRE_DATE_CK    
--CHECK(HireDate>'01.01.1990')

--TASK 5
--ALTER TABLE Teacher
--ADD CONSTRAINT Code_UQ    
--UNIQUE(Code)

--TASK 6
--ALTER TABLE Teacher
--ALTER COLUMN Salary NUMERIC(6,2)

--TASK 7
--ALTER TABLE Teacher
--ADD CONSTRAINT Salary_CK    
--CHECK(Salary>1000 AND Salary<5000)

--TASK 8
--EXEC sp_rename 'dbo.Teacher.Tel', 'Phone', 'COLUMN';

--TASK 9
--ALTER TABLE Teacher
--ALTER COLUMN Phone char(11)

--TASK 10
--CREATE TABLE POST
--(
--	Id int PRIMARY KEY IDENTITY(1,1),
--	[Name] nvarchar(20)
--	)

--TASK 11 ???
--ALTER TABLE POST
--ADD CONSTRAINT Name_CK    
--CHECK([Name]='профессор' OR [Name]='доцент' OR  [Name]='преподаватель' OR  [Name]='ассистент' )

--TASK 12 ???
--ALTER TABLE Teacher
--ADD CONSTRAINT T_Name_CK    
--CHECK([Name]='%[^0-9]%')

--TASK 13
--ALTER TABLE Teacher
--ADD  IdPost int


--TASK 14
--ALTER TABLE Teacher
--ADD FOREIGN KEY(IdPost) REFERENCES POST(Id)

--TASK 15
--SET IDENTITY_INSERT dbo.TEACHER OFF
--SET IDENTITY_INSERT dbo.POST ON
--INSERT INTO POST(Id,Name) VALUES(1,N'Профессор');
--INSERT INTO post(Id,Name) VALUES(2,N'Доцент');
--INSERT INTO post(Id,Name) VALUES(3,N'Преподаватель');
--INSERT INTO post(Id,Name) VALUES(4,N'Ассистент');

--SET IDENTITY_INSERT dbo.POST OFF
--SET IDENTITY_INSERT dbo.TEACHER ON
--INSERT INTO TEACHER (Id, Name, Code, IdPost, phone, Salary, Rise, HireDate)
--VALUES (1, N'Сидоров','0123456789', 1, NULL, 1070, 470, '01.09.1992');
--INSERT INTO TEACHER (Id, Name, Code, IdPost, phone, Salary, Rise, HireDate)
--VALUES (2, N'Рамишевский','4567890123', 2, '4567890', 1110, 370, '09.09.1998');
--INSERT INTO TEACHER (Id, Name, Code, IdPost, phone, Salary, Rise, HireDate)
--VALUES (3, N'Хоренко','1234567890', 3, NULL, 2000, 230, '10.10.2001');
--INSERT INTO TEACHER (Id, Name, Code, IdPost, phone, Salary, Rise, HireDate)
--VALUES (4, N'Вибровский','2345678901', 4, NULL, 4000, 170, '01.09.2003');
--INSERT INTO TEACHER (Id, Name, Code, IdPost, phone, Salary, Rise, HireDate)
--VALUES (5, N'Воропаев',NULL, 4, NULL, 1500, 150, '02.09.2002');
--INSERT INTO TEACHER (Id, Name, Code, IdPost, phone, Salary, Rise, HireDate)
--VALUES (6, N'Кузинцев','5678901234', 3, '4567890', 3000, 270, '01.01.1991');

--TASK 16.1
--CREATE VIEW Position
--AS 
--SELECT [Name]
--FROM POST

--TASK 16.2
--CREATE VIEW Surnames
--AS 
--SELECT [Name]
--FROM TEACHER

--TASK 16.3
--CREATE VIEW TeachersInfo
--AS 
--SELECT  T.Id, T.[Name] AS [Name], P.[Name] AS [Position],  T.Salary+T.Rise AS [Total Salary]
--FROM TEACHER AS T
--JOIN POST AS P
--ON P.Id=T.IdPost
--ORDER BY  [Total Salary] 
--OFFSET 0 ROW

--TASK 16.4
--CREATE VIEW TeachersPhone
--AS 
--SELECT  Id, [Name], Phone
--FROM TEACHER 
--WHERE Phone IS NOT NULL 
