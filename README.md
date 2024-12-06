# MIST-353-Gym-Tracker-Repo
Remake of our old github since it was easier to do it this way then fix the mess of a repo our old one was.

Final Documentation

Deployment Guide:

1. Assuming the user is using a blank VM, Firstly the user will have to install the most recent version of Microsoft Visual Studio alongside SQL Server Management Studio 20. With this done the user would now navigate to GitHub where they will search for this repo that were in currently and copy the link to the repo.

2. With that done the user will boot up MVS and click clone repo at the top right where they will input the link from the github alongside adding a path that the repo can reside in.

3. One thing to note is that there are many NuGet packages requried for this project which I will list here:

Microsoft.Data.SqlClient

Microsoft.EntityFrameworkCore

Microsoft.EntityFrameworkCore.Relational

Microsoft.EntityFrameworkCore.SqlServer

Microsoft.SqlServer.Server

Some of these may not be entirly requried but, its easier to install and extra package rather than spending a long time debugging.



Possible Pitfall: Insure a .gitignore is present in the repo if you as the user planning to make change because it will try and stage your entire hard drive (Been there)

3. With the user being in the project now they will now have to setup the database connection. With the database, the user will log into their with their azure or with a pre provided database. Once in the user will have to go back to MVS and ensure the following statement is present within appsettings.json

Possible Pitfall(s): Ensure that the following step is done in BOTH projects (Razors frontend and API backend). Also ensure that both projects are selected upon start up of the build since full functionalty wont be possible without both

4. This statement,
5.  {
  "ConnectionStrings": {
    "DefaultConnection": "Data Source=labH7SR1J;Initial Catalog=GymTrackerDB;Integrated Security=True;TrustServerCertificate=True;"
  },
  "Logging": {

is an example of a database connection. Looking at the code the connection to the database is based on the name of VM (in this example) and the catalog is the name of the DB you want to use 

Pitfall: ensure the spacing is correct in this statement since improper spacing might cause it not to function

6. Once connectivity is established, the user will navigate to the SQL folder within the main project for the frontned. There will be two files in here called DatabaseCreation and DatabaseData which the user will navigate to and copy and paste each page into two seprate querys within the SQL manager starting with creation. This will make the tables and the data file will make the mock data.

7. Once this has all been completed the user should be able to fully use the appilication if they followed the steps and avoided the pitfalls.

For help with errors there are many different sources of assistance such as, The error help function in the IDE, Stack OverFlow, Resources on Ecampus, W3Schools, Copliot AI within MVS, Chatgpt, Mr Meadows, Our Group! 


API Functionatilty:

This is going to be cut into sections based on group members work with a summary at the end.

Ryan's API's:

API 1: The first API's goal is meant for a user search within the website. The overall goal of this API is to allow users to search for other users or search for themselves and see what comes up. 
The output within the API backend will display this
"id": 4,
    "userName": "Toddy12",
    "userPassword": 221212,
    "userEmail": "T12@gmail.com",
    "userAddress": "1234 duke drive",
    "userCity": "Woodbine",
    "userJoined": "2024-10-01T00:00:00",
    "userLevel": "2"
The output for the frontend will display this
Search Results
Username: Toddy12
Email: T12@gmail.com 
User Level: 2

The display for the frontend will look a bit different here than in MVS but the data is the same

The user will input an ID and say for example they input 4 which will show the user with that ID and if they put in 109222 which is not in the DB it will show up with not found and allow the user to search again.

The outputs will be like whats displayed above this but to summarize it will out the users full dataset with in the database when inputted directly to the API and the frontend will output only username, email, and user level. 

To use the API first ensure that you followed the steps in the deployment guide to be up to this point. You can either use the API through the backend which will give you the raw data from the DB. You can do this when both projects start one will be a window with Swagger and the other a regular website. Use swagger and hit try out and input an ID and for frontend just search for an ID on the main page.

API 2: This API allows the user to search for a gyms location by gym name. The user will input a name such as FitFusion which will give an output of the gyms city alongside its opening and closing time. 

The output for the backend will look like this
[
  {
    "id": 1,
    "gymName": "FitFusion",
    "gymCity": "Miami",
    "openTime": "08:00:00",
    "closeTime": "11:00:00"
  }
]
The output for the frontend will look like this
FitFusion - 08:00:00 - 11:00:00

Once again it will look different then here on the frontend website. This API is different since the user on the frontend will search by name rather than ID. 

Same thing as before with using it you can do it through the backend or the frontend and the difference with this one is the backend displays all data which is just adding in ID and the frontend will display city and the opening and closing time.

END RYANS APIS

Our Application serves as a general website where the user can do things like search for other users and friends and see how far along they are level wise. Or they could find new workouts from a page that we have that shows examples. Alongside this, they can check out the about us page to know about the company and theres also a page to contact the team. This is just some of the features our application has and the goal of this app is to have everything a gym goer could want in one single application without having to go outside of it to find new things when it comes to the gym.


DAVISON's API:
API #1- The purpose of this API is to allow the user to enter an email on the website that will be sent to a database. There will be page and the first thing it will show is a white box to enter one email which is clearly labeled. The user will hit enter, the email will be sent to the database, and a "Thank you! Your email has been sent." box will appear notifying the user that the goal was succesfully completed. 
Note: The email will be visible on the database after running the proper sql query command. 

API #2- The purpose of this API is to allow users to search for the weather forecast of any particular day that they would want to exercise outside. The user will enter the date of the day, press enter, and the weather forcast including, temperature and chance of rain, will be fetched from the database. 
Note: This is what the output will look like. 
[
  {
    "id": 14,
    "date": "2024-10-10T00:00:00",
    "temp": 73,
    "chanceOfRain": 10
  }
]


END DAVISON's APIs. 


JOSHUA'S APIs. 

Deployement guide -- 
API #1 steps
The steps they should take is to start with the Membership API to see what memberships are avalible and the cost of those memberships. They will first use the first Membership API to see what memberships are avalible in there area then use the second API to see what the cost of the Membership is. The pitfalls to avoid is to make sure you type in the membership Level starting with a capital letter. If you run into errors try to redo it and make sure your course has the correct ID. 

API #2 steps
Then once they have there membership they should go the course API and do the first one to see the prices of the course. Then they will have to to go the second part of the Course API to lookup the ID number for the course to see what the price would be. This will help customers see what the price of certain courses are. 



This application is a lookup website where customers and employees can lookup each day what courses are avalible and what memberships are avalible. I would want them to know that it needs work with dates and the website would need to look better. There is so much more I could accomplish to make this perfect. 



