use GymTrackerDB
GO

-- add exercise 
create proc spExerciseAdd
	@exercise_name nvarchar(255),
	@exercise_equipment nvarchar(255),
	@exercise_muscleTarget nvarchar(255) 

	AS
	BEGIN
		insert into ext_exercise(exercise_name, exercise_equipment, exercise_muscleTarget)
		values (@exercise_name, @exercise_equipment, @exercise_muscleTarget)
	END
	GO

	/*
	EXEC spExerciseAdd
	@exercise_name = 'crossbody curl',
	@exercise_equipment = 'dumbell',
	@exercise_muscleTarget = 'bicep'

	GO
	*/


-- show all apperal in the database
create proc spApperalGetAll
	AS
BEGIN
	select *
	FROM ext_exercise_apperal
END
GO
/*
exec spApperalGetAll
GO
*/