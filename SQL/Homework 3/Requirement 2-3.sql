--Requirement part 2
--Calculate the count of all grades per Teacher in the system and filter only grade count greater then 200

SELECT TeacherID, SUM (Grade) AS GraterFilter200
FROM Grade
GROUP BY TeacherID
HAVING SUM(Grade) > 200

--Calculate the count of all grades per Teacher in the system for first 100 Students (ID < 100) and filter teachers with more than 50 Grade count

SELECT TeacherID, SUM(Grade) as GreaterFilter50
FROM Grade
WHERE ID < 100
GROUP BY TeacherID
HAVING SUM(Grade) > 50

--Find the Grade Count, Maximal Grade, and the Average Grade per Student on all grades in the system. Filter only records where Maximal Grade is equal to Average Grade

SELECT TeacherID, COUNT(Grade) as GradeCount, MAX(Grade) as Maximal, AVG(Grade) as Average
FROM Grade
GROUP BY TeacherID
HAVING  MAX(Grade) = AVG(Grade)

--List Student First Name and Last Name next to the other details from previous query

SELECT StudentID, b.FirstName, b.LastName, COUNT(Grade) as GradeCount, MAX(Grade) as Maximal, AVG(Grade) as Average
FROM Grade g
inner join Student b on b.ID = g.StudentID
GROUP BY StudentID, b.FirstName, b.LastName 
HAVING  MAX(Grade) = AVG(Grade)