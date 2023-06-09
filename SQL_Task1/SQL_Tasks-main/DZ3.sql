-- Task 1
--SELECT  *
--FROM Books_En
--WHERE Publisher!=N'Peter' AND Price<20


-- Task 2
--SELECT  *
--FROM Books_En
--WHERE Publisher!=N'Peter' AND Price BETWEEN 20 AND 40

-- Task 3
--SELECT  *
--FROM Books_En
--WHERE Publisher!=N'Peter' AND Price BETWEEN 20 AND 40 OR Price<10

-- Task 4
--SELECT  *
--FROM Books_En
--WHERE Pages!=0 AND Price/Pages<0.1

-- Task 5
--SELECT  *
--FROM Books_En
--WHERE Category IN (N'C & C ++', N'other books')  AND Publisher IN (N'Peter', N'DiaSoft') 

-- Task 6
--SELECT  *
--FROM Books_En
--WHERE [Name] LIKE N'%Windows%'

-- Task 7
--SELECT  *
--FROM Books_En
--WHERE [Name] LIKE N'%Windows%' AND [Name] NOT LIKE N'%Microsoft%'

-- Task 8
--SELECT  *
--FROM Books_En
--WHERE [Name] LIKE N'%[0-9]%'

-- Task 9
--SELECT  *
--FROM Books_En
--WHERE [Name] LIKE N'%[0-9]%[0-9]%[0-9]%'