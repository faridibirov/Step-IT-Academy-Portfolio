1. Создать базу данных «Преподаватели» и добавить в неё две таблицы.

![Screenshot](screenshot.png)

<br>2. Удалить таблицу «POST».
<br>3. В таблице «TEACHER» удалить столбец «IdPost».
<br>4. Для столбца «HireDate» создать ограничение: дата приёма на работу должна быть не меньше 01.01.1990.
<br>5. Создать ограничение уникальности для столбца «Code».
<br>6. Изменить тип данных в поле Salary c INTEGER на NUMERIC(6,2).
<br>7. Добавить в таблицу «TEACHER» следующее ограничение: зарплата не должна быть ниже 1000, но и не должна превышать 5000.
<br>8. Переименовать столбец Tel на Phone.
<br>9. Изменить тип данных в поле Phone с CHAR(7) на CHAR(11).
<br>10. Создать снова таблицу «POST».
<br>11. Для поля Name таблицы «POST» задать ограничение на должность (профессор, доцент, преподаватель или ассистент).
<br>12. Для поля Name таблицы «TEACHER» задать ограничение, в котором запретить наличие цифр в фамилии преподавателя.
<br>13. Добавить столбец IdPost (int) в таблицу «TEACHER».
<br>14. Связать поле IdPost таблицы «TEACHER» c полем Id таблицы «POST».
<br>15. Заполнить обе таблицы данными.
<br>INSERT INTO post(Id,Name) VALUES(1,N'Профессор');
<br>INSERT INTO post(Id,Name) VALUES(2,N'Доцент');
<br>INSERT INTO post(Id,Name) VALUES(3,N'Преподаватель');
<br>INSERT INTO post(Id,Name) VALUES(4,N'Ассистент');
<br>INSERT INTO TEACHER (Id, Name, Code, IdPost, phone, Salary, Rise, HireDate) VALUES (1, N'Сидоров','0123456789', 1, NULL, 1070, 470, '01.09.1992');
<br>INSERT INTO TEACHER (Id, Name, Code, IdPost, phone, Salary, Rise, HireDate) VALUES (2, N'Рамишевский','4567890123', 2, '4567890', 1110, 370, '09.09.1998');
<br>INSERT INTO TEACHER (Id, Name, Code, IdPost, phone, Salary, Rise, HireDate)
VALUES (3, N'Хоренко','1234567890', 3, NULL, 2000, 230, '10.10.2001');
<br>INSERT INTO TEACHER (Id, Name, Code, IdPost, phone, Salary, Rise, HireDate)
VALUES (4, N'Вибровский','2345678901', 4, NULL, 4000, 170, '01.09.2003');
<br>INSERT INTO TEACHER (Id, Name, Code, IdPost, phone, Salary, Rise, HireDate)
VALUES (5, N'Воропаев',NULL, 4, NULL, 1500, 150, '02.09.2002');
<br>INSERT INTO TEACHER (Id, Name, Code, IdPost, phone, Salary, Rise, HireDate)
VALUES (6, N'Кузинцев','5678901234', 3, '4567890', 3000, 270, '01.01.1991');

<br>16. Cоздать представления:

<br>16.1. Все названия должностей.
<br>16.2. Все фамилии учителей.
<br>16.3. Идентификатор, фамилия учителя, его должность, общая з\п
(сортировать по з\п).
<br>16.4. Идентификационный номер, фамилия, номер телефона (только те, у
кого есть номер телефона).
