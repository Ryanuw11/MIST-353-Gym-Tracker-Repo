use GymTrackerDB
GO

--Query to look up the name of a certain gym and its opening time
Create proc spGymLocAndOpen
@gym_name nvarchar,
@open_time time

AS

BEGIN
	select *
	from ext_gym_org
	where gym_name = @gym_name AND open_time = @open_time;

END
GO

	exec spGymLocAndOpen @gym_name = 'FitFusion', @open_time = '7:00';
	GO


--Query to lookup a users level
create proc spUserLookup

@user_level int
AS
BEGIN
	select * 
	from ext_user_data
	where user_level=@user_level;

END
GO

exec spUserLookup @user_level = 2;
GO



