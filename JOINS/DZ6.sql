-- TASK 1
--SELECT * 
--FROM Books AS B JOIN Press AS P
--ON B.Id_Press=P.Id

-- TASK 2
--SELECT * 
--FROM Books AS B JOIN Authors AS A
--ON B.Id_Author=A.Id

-- TASK 3
--SELECT * 
--FROM Books AS B JOIN Categories AS C
--ON B.Id_Category=C.Id

-- TASK 4
--SELECT * 
--FROM Books AS B JOIN Press AS P
--ON B.Id_Press=P.Id
--JOIN Authors AS A
--ON B.Id_Author=A.Id

---- TASK 5
--SELECT * 
--FROM Students AS S JOIN Groups AS G
--ON S.Id_Group=G.Id
--JOIN Faculties AS F
--ON G.Id_Faculty=F.Id

------ TASK 6
--SELECT * 
--FROM Students AS S JOIN S_Cards AS SC
--ON S.Id=SC.Id_Student
--JOIN Books AS B
--ON B.Id=SC.Id_Book

------ TASK 7
--SELECT * 
--FROM Teachers AS T JOIN T_Cards AS TC
--ON T.Id=TC.Id_Teacher
--JOIN Books AS B
--ON B.Id=TC.Id_Book