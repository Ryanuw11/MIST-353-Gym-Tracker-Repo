# MIST-353-Gym-Tracker-Repo
Remake of our old github since it was easier to do it this way then fix the mess of a repo our old one was.

Final Documentation

Deployment Guide:

1. Assuming the user is using a blank VM, Firstly the user will have to install the most recent version of Microsoft Visual Studio alongside SQL Server Management Studio 20. With this done the user would now navigate to GitHub where they will search for this repo that were in currently and copy the link to the repo.

2. With that done the user will boot up MVS and click clone repo at the top right where they will input the link from the github alongside adding a path that the repo can reside in.

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

6. 



