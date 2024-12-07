


--Creating procedure for name input on the web app. 
use GymTrackerDB
go

create proc Customer_Email_Input
@Email nvarchar(225)
as 
begin 

insert into Customer_Email
(Email) 
values 
(@Email)

end 
Go

EXECUTING PROC
exec Email_Add @Email=’Elon.Musk@gmail.com’ 
go

create proc GetWeather
    @Date DATE
AS

  
    BEGIN
        SELECT 
            Date, 
			ChanceOfRain,
			Temp
        FROM 
            WeatherData
        WHERE 
            Date = @Date;
    
END
go

EXECUTING PROC             
exec GetWeather @Date=’2024-10-10’
go



