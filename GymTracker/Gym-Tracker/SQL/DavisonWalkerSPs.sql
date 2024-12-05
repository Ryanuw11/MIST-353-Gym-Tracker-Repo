


--Creating procedure for name input on the web app. 
use GymTrackerDB
go



create proc Customer_Name_Input
@First_Name nvarchar(225), @Last_Name nvarchar(225)
as 
begin 

insert into Customer
(First_Name, Last_Name)
values 
(@First_Name, @Last_Name)

end 

--Executing procedure

exec Customer_Name_Input 
@First_Name='userinput', @Last_Name='userinput'
go 

--Creating procedure for email input on the web app. 
use GymTrackerDB
go

create proc Customer_Email_Input
@Email nvarchar(225), @Customer_ID int 
as 
begin 

insert into Customer_Email
(Email, Customer_ID) 
values 
(@Email, @Customer_ID)

end 

--Executing procedure 

exec Email_Add @Email='userinput', @Customer_ID=userinput
go 
