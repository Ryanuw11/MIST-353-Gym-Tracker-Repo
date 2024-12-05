USE GymtrackerDB
GO


-- Query that looks up people with a Bronze membership and who has it for 12 months

Create proc MembershipLevelLength
@MembershipLevel varchar(8),
@MembershipMonthLength int

AS

BEGIN
	select *
	from Membership
	where  MembershipLevel = @MembershipLevel AND MembershipMonthLength = @MembershipMonthLength;

	END
	GO

	exec MembershipLevelLength @MembershipLevel = 'Bronze', @MembershipMonthLength = '12';
	GO

	--TESTED Query ALL set 

	Create proc ClassP
	@ClassPrice Decimal(6,2)

	AS

	BEGIN 
	Select * 
	FROM Course
	where  ClassPrice = @ClassPrice;

	END
	GO

	exec ClassP @ClassPrice = '1.99';


	--TESTED PROCEDURE ALL set