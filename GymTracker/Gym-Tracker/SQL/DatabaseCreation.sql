create GymTrackerDB
GO 
use GymTrackerDB
GO

--Knipel Tables, exercises and recommended apperal for each exercise

CREATE TABLE [ext_exercise](
	[exercise_id] int PRIMARY KEY IDENTITY(1, 1),
	[exercise_name] nvarchar(255) NOT NULL,
	[exercise_equipment] nvarchar(255) NULL,
	[exercise_muscleTarget] nvarchar(255) NOT NULL,
	)
GO

CREATE TABLE [ext_exercise_apperal](
	[apperal_id] int PRIMARY KEY IDENTITY(1, 1),
	[apperal_type] nvarchar(255) NOT NULL,
	[apperal_brand] nvarchar(255) NOT NULL,
	[apperal_material] nvarchar(255) NOT NULL,
	[apperal_exercise] int NOT NULL,
	)
GO


ALTER TABLE [ext_exercise_apperal] ADD FOREIGN KEY ([apperal_exercise]) REFERENCES [ext_exercise] ([exercise_id])

GO

--the following code is Ryan Dowds

--This creates the table for the gyms location with its name, city, and hours of operation
CREATE TABLE [ext_gym_org] (
	[id] int PRIMARY KEY IDENTITY(1, 1),
	[gym_name] nvarchar(255) UNIQUE NOT NULL,
	[gym_city] nvarchar(255) NOT NULL,
	[open_time] time,
	[close_time] time
	)
	GO


-- This creates the table for the users data which stores basic data about the user along the date the user joined the app.
-- It also tracks the users level which corresponds to exp the user gets for using the app
CREATE TABLE [ext_user_data] (
	[id] int PRIMARY KEY IDENTITY(1, 1),
	[user_name] nvarchar(255) NOT NULL,
	[user_password] int NOT NULL,
	[user_email] nvarchar(255) NOT NULL,
	[user_address] nvarchar(255) NOT NULL,
	[user_city] nvarchar(255) NOT NULL,
	[user_joined] date,
	[user_level] nvarchar(255) NOT NULL
	)
	GO

-- Josh Morrsion tables

-- Membership Table created with a primary key and the levels of membership 
	
CREATE TABLE Membership (
    ID int NOT NULL PRIMARY KEY,
    MembershipLevel varchar(8) NOT NULL,
    MembershipMonthPrice Decimal(10,2),
    MembershipMonthLength int
);
GO


-- Courses avalible on the app that are home workouts with professional Trainers for a price. 

CREATE TABLE Course
(
CID int NOT NULL PRIMARY KEY,
CourseName varchar(50) NOT NULL,
LengthMinutes int NOT NULL, 
TrainerFirstName varchar(50) NOT NULL,
TrainerLastName varchar(50) NOT NULL,
ClassPrice Decimal(6,2) NOT NULL,
);

GO

--davison tables

--Contact Us tables -Davison Walter



-- Creating the tables to hold user input for the 'Contact Us' page of the web app.
use GymTrackerDB
go 

create table Customer_Email
(Email nvarchar(225) not null)
go 


Create table WeatherData 
(Id int identity (1,1) not null primary key, Date date not null, ChanceOfRain int, Temp int)
go

