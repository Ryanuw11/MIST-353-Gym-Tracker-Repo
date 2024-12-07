// This is the readme we will use for assignment 3

**Company Statement
We plan on adding my different functions into our database such as user data and gym locations with their locatgions and opening hours. Alongside this, we plan to add in memebership levels and other functions to our database.

***Ryans Part
I worked on the user and data and gym locations data and tables. My ideas for user function was to have a user name and password system and a profile that stores the user data so that my other other idea the gym locations could functin in tandem with. The user would input where they live and in turn the app would provide the closest gyms to that location.

I didnt use much chatgpt besides trouble shooting time data where I asked how to get the time into a "8:00" format instead of the normal "8:00:0000000"


*** Josh's Part
The tables I created were the Membership and Course tables. The goal of these tables were to store availble memberships and courses that are avalible on the app. The courses table shows the trainers name, price of course, length of video and the course ID. The purpose of this is so the app user can see what they like and see what they might want to purchase. The membership table links a user's ID to each membership. This table includes the price per month and how many months they agreed to. 

No Chatgpt, W3 schools and some forum websites to look up what to use for a datatype for the price. 

*** Dalton's part
Created exercise and workout apperal tables and mock data. 

ChatGPT prompts for inserting mock data: 
give me mock data for the following tables CREATE TABLE [ext_exercise](
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

--Davison's Contribution:
I worked on the 'Contact Us' page. I made a table and data for it. On the contact page, there will also be a weather interface, so the user can check the weather. I made the weather table and data. 

