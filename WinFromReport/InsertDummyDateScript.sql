USE [LsiReportDB]
GO

INSERT INTO [dbo].[Users]
           ([FirstName]
           ,[LastName]
           ,[UserName]
           ,[Email])
     VALUES
           ('FirstName1', 'LastName1','UserName1','email1@gmail.com'),
		   ('FirstName2', 'LastName2','UserName2','email2@gmail.com'),
		   ('FirstName3', 'LastName3','UserName3','email3@gmail.com'),
		   ('FirstName4', 'LastName4','UserName4','email4@gmail.com'),
		   ('FirstName5', 'LastName5','UserName5','email5@gmail.com'),
		   ('FirstName6', 'LastName6','UserName6','email6@gmail.com'),
		   ('FirstName7', 'LastName7','UserName7','email7@gmail.com'),
		   ('FirstName8', 'LastName8','UserName8','email8@gmail.com'),
		   ('FirstName9', 'LastName9','UserName9','email9@gmail.com'),
		   ('FirstName10', 'LastName10','UserName10','email10@gmail.com');
GO

USE [LsiReportDB]
GO

INSERT INTO [dbo].[Premises]
           ([PremisesName])
     VALUES
           ('Premises1'),
		   ('Premises2'),
		   ('Premises3'),
		   ('Premises4'),
		   ('Premises5'),
		   ('Premises6'),
		   ('Premises7'),
		   ('Premises8'),
		   ('Premises9'),
		   ('Premises10');
GO

USE [LsiReportDB]
GO
CREATE PROCEDURE [dbo].[InsertDummyData] @UserID int, @PremisesId int
AS
	DECLARE @total as int
	declare @premisesName as varchar(100)
	SET @total  = 0 
	WHILE  @total <= 300
	BEGIN
		select @premisesName = PremisesName from Premises where id = @PremisesId;
		SET @total = @total + 1;
		insert into Reports (ReportName, ReportDateTime, UserId, PremisesId)
		values(N'Report' + cast(@total as varchar) + ' from ' + @premisesName, DATEADD(day, @total, DATEADD(year, -1, GETDATE())), @UserID, @PremisesId);
	END

USE [LsiReportDB]
GO
EXEC InsertDummyData @UserID = 1, @PremisesId = 1;
EXEC InsertDummyData @UserID = 2, @PremisesId = 2;
EXEC InsertDummyData @UserID = 3, @PremisesId = 3;
EXEC InsertDummyData @UserID = 4, @PremisesId = 4;
EXEC InsertDummyData @UserID = 5, @PremisesId = 5;
EXEC InsertDummyData @UserID = 6, @PremisesId = 6;
EXEC InsertDummyData @UserID = 7, @PremisesId = 7;
EXEC InsertDummyData @UserID = 8, @PremisesId = 8;
EXEC InsertDummyData @UserID = 9, @PremisesId = 9;
EXEC InsertDummyData @UserID = 10, @PremisesId = 10;