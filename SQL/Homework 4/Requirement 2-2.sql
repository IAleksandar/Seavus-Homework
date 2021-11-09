--Homework requirement2/2

--Declare scalar function (fn_FormatStudentName) for retrieving the Student description for specific StudentIdin the following format:
--StudentCardNumberwithout “sc-”
--“ –“
--First character  of student  FirstName
--“.”
--Student LastName
DROP FUNCTION IF EXISTS dbo.fn_FormatStudentName;
CREATE FUNCTION dbo.fn_FormatStudentName(@StudentID int)
	RETURNS nvarchar(2000)
	AS
	BEGIN
		
		declare @Result nvarchar(2000)

			select @Result = RIGHT(StudentCardNumber,5) + '-' + LEFT(FirstName,1) + '.' + LastName
			from Student
			where id = @StudentID
			

		RETURN @Result
	END
	GO

	--select dbo.fn_FormatStudentName()

	select *,dbo.fn_FormatStudentName (id) as Result
	from Student
	


	



