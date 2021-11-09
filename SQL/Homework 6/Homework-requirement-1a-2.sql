--Homework requirement 1a/2

--Create new procedure called CreateGrade
--Procedure should create only Grade header info (not Grade Details) 
--Procedure should return the total number of grades in the system for the Student on input (from the CreateGrade)
--Procedure should return second resultset with the MAX Grade of all grades for the Student and Teacher on input (regardless the Course)



CREATE PROCEDURE dbo.CreateGrade (@StudentId int, @TeacherId int)
AS
BEGIN

    INSERT INTO [dbo].[Grade] (StudentId, TeacherId)
    VALUES (@StudentId, @TeacherId)


    select count(*) as TotalGrades
    FROM [dbo].[Grade] o
    where StudentID = @StudentId

    select MAX(Grade) as MaxGrade
    FROM [dbo].[Grade] o
    where StudentID = @StudentId
    and TeacherID = @TeacherId

END
GO

EXEC dbo.CreateGrade  @StudentId =5, @TeacherID=7 
select * 
from [dbo].[Grade]
order by 1 desc