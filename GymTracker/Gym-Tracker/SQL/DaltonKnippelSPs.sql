use GymTrackerDB
GO


--Get all exercise information for a single workout with an exercise ID number
create proc [dbo].[spExerciseGetAll]
@exercise_id int 
	AS
BEGIN
	SELECT
	[exercise_id],
	[exercise_name],
	[exercise_equipment],
	[exercise_muscleTarget]
	FROM ext_exercise
WHERE
exercise_id=@exercise_id

END
GO


exec spExerciseGetAll
GO

-- show all apperal information for a particualr piece of apperal by ID number
create proc [dbo].[spApperalGetAll]
@apperal_id int
	AS
BEGIN
	select 
	[apperal_id]
      ,[apperal_type]
      ,[apperal_brand]
      ,[apperal_material]
      ,[apperal_exercise]
	FROM ext_exercise_apperal
WHERE
	apperal_id=@apperal_id
END
GO

exec spApperalGetAll
GO