use GymTrackerDB
GO

--insert sample exercises
INSERT INTO [ext_exercise] ([exercise_name], [exercise_equipment], [exercise_muscleTarget])
VALUES
('Push-up', NULL, 'Chest, Triceps, Shoulders'),
('Squat', NULL, 'Quads, Hamstrings, Glutes'),
('Deadlift', 'Barbell', 'Back, Hamstrings, Glutes'),
('Pull-up', NULL, 'Back, Biceps'),
('Plank', NULL, 'Core'),
('Bench Press', 'Barbell', 'Chest, Triceps, Shoulders'),
('Lunges', NULL, 'Quads, Glutes, Hamstrings'),
('Overhead Press', 'Dumbbells', 'Shoulders, Triceps'),
('Bicep Curl', 'Dumbbells', 'Biceps'),
('Leg Press', 'Leg Press Machine', 'Quads, Hamstrings, Glutes');

GO




--insert sample apperal
INSERT INTO [ext_exercise_apperal] ([apperal_type], [apperal_brand], [apperal_material], [apperal_exercise])
VALUES
('T-shirt', 'Nike', 'Cotton', 1),  -- Push-up
('Shorts', 'Adidas', 'Polyester', 2),  -- Squat
('Tank Top', 'Under Armour', 'Polyester', 3),  -- Deadlift
('Gym Gloves', 'Reebok', 'Leather', 4),  -- Pull-up
('Compression Shorts', 'Nike', 'Spandex', 5),  -- Plank
('Jacket', 'Puma', 'Nylon', 6),  -- Bench Press
('Running Shoes', 'Asics', 'Mesh', 7),  -- Lunges
('Wrist Wraps', 'Titan', 'Neoprene', 8),  -- Overhead Press
('Resistance Bands', 'Bodylastics', 'Latex', 9),  -- Bicep Curl
('Leggings', 'Lululemon', 'Nylon', 10);  -- Leg Press

GO

-- These are the inserts for ryan dowd sample users and gym locations

--Inserts data into the gym_org table
INSERT INTO [ext_gym_org] (gym_name, gym_city, open_time, close_time) 

VALUES
('FitFusion', 'Miami', CAST('7:00' AS TIME),  CAST('21:00' AS TIME)),
('IronCoreFitness', 'Dallas',  CAST('7:00' AS TIME),  CAST('15:00' AS TIME)),
('MuscleForge', 'Nevada',  CAST('8:00' AS TIME),  CAST('17:00' AS TIME)),
('ReviveFitness', 'PortLand',  CAST('5:00' AS TIME),  CAST('19:00' AS TIME));
GO

--josh morrison data
--Inserts Data into user_data table
INSERT INTO [ext_user_data] (user_name, user_password, user_email, user_address, user_city, user_joined, user_level)

VALUES

('MVS123', '12234', 'MVS@yahoo.com','122 trailrd','Woodbridge','12-24-22','12'),
('Toddy12', '221212', 'T12@gmail.com', '1234 duke drive', 'Woodbine', '10-1-24', '2');

-- Insert data into Membership table
INSERT INTO Membership (ID,MembershipLevel,MembershipMonthPrice,MembershipMonthLength)

VALUES
('1','Bronze','2.99','12'),
('2','Gold','9.99','12'),
('3','Gold','9.99','8'),
('4','Silver','7.99','9'),
('5','Bronze','2.99','10'),
('6','Silver','7.99','10'),
('7','Gold','9.99','18'),
('8','Bronze','2.99','12'),
('9','Gold','9.99','8'),
('10','Silver','7.99','6'),
('11','Gold','9.99','6'),
('12','Silver','7.99','10');


GO

-- Classes that are avalible online
INSERT INTO Course (CID,CourseName,LengthMinutes,TrainerFirstName,TrainerLastName,ClassPrice)


VALUES
('1','Jogging','60','Johnny','Gomes','2.99'),
('2','Arms','30','Ava','Smith','1.99'),
('3','Pull Up','15','Joey','Johnson','12.99'),
('4','Bench','10','Mila','Mighty','1.99'),
('5','Boxing','30','Mike','Tyson','24.99'),
('6','MMA','90','Jon','Jones','249.99'),
('7','Sprinting','45','Jose','Altuve','12.99'),
('8','StairMaster','5','Spongebob','Squarepants','0.99');

GO



--davison walter's mock data

--Creating mock data for the tables.


insert into Customer
(First_Name, Last_Name)
values
('Peter', 'Parker'), ('Wade', 'Wilson'), ('Steve', 'Rogers')
go 


insert into Customer_Email
(Email, Customer_ID)
values
('peter.parker@gmail.com', 1),
('wade.wilson@gmail.com', 2),
('steve.rogers@gmail.com', 3)
go 
