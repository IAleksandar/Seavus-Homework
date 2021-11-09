--Homework requirement 1b/2

--Create new procedure called CreateGradeDetail
--Procedure should add details for specific Grade (new record for new AchievementTypeID, Points, MaxPoints, Date for specific Grade)
--Output from this procedure should be resultset with SUM of GradePoints calculated with formula
--AchievementPoints/AchievementMaxPoints*ParticipationRate for specific Grade

CREATE PROCEDURE dbo.CreateGradeDetail (@Grade int, @AchievementTypeId int, @Points int,@MaxPoints int, @Date date)
AS
BEGIN

-- output
    SELECT sum(gd.AchievementPoints/gd.AchievementMaxPoints * p.ParticipationRate) as SumOfGradePoints
    FROM [dbo].[Grade] o
    INNER JOIN [dbo].[GradeDetails] gd on gd.GradeID = o.ID
    INNER JOIN [dbo].[AchievementType] p on p.ID = gd.AchievementTypeID
    WHERE o.Grade = @Grade

END
GO

EXEC dbo.CreateGradeDetail @Grade=7, @AchievementTypeId = 8, @Points = 50, @MaxPoints =100, @Date ='1999-02-02'
EXEC dbo.CreateGradeDetail @Grade=8, @AchievementTypeId = 0, @Points = 72, @MaxPoints =100, @Date ='1999-02-02'

SELECT * FROM [dbo].[GradeDetails]
WHERE id = 4206