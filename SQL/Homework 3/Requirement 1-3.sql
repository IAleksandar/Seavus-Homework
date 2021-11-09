--Requirement part 1
--Calculate the count of all grades in the system

SELECT COUNT (Grade) AS AllGrades
FROM Grade

--Calculate the count of all grades per Teacher in the system

SELECT TeacherID, SUM (Grade) AS GradesPerTeacher
FROM Grade
GROUP BY TeacherID

--Calculate the count of all grades per Teacher in the system for first 100 Students (ID < 100)

SELECT TeacherID, COUNT(Grade) as Total
FROM Grade
WHERE ID < 100
GROUP BY TeacherID

--Find the Maximal Grade, and the Average Grade per Student on all grades in the system

SELECT StudentID, MAX(Grade) as Maximal, AVG(Grade) as Average
FROM Grade
GROUP BY StudentID
