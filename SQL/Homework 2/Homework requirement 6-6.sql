-- List all possible combinations of Courses names and AchievementType names that can be passed by student

SELECT c.Name AS CoursesName, a.Name AS AchievementTypeName
FROM Course c
CROSS JOIN AchievementType a


-- List all Teachers that has any exam Grade

SELECT DISTINCT t.FirstName 
FROM Teacher t
INNER JOIN Grade g ON t.ID = g.TeacherID

-- List all Teachers without exam Grade

SELECT DISTINCT t.FirstName
FROM Teacher t
LEFT JOIN Grade g ON t.ID = g.TeacherID
WHERE g.TeacherID IS NULL


-- List all Students without exam Grade (using Right Join)

SELECT g.*
FROM Grade g
RIGHT JOIN Student s ON g.StudentID = s.ID
WHERE g.StudentID IS NULL
