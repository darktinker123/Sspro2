CREATE DATABASE dbiLocator

CREATE TABLE tblUserLogs
(
	userLogID INT IDENTITY,
	usertype VARCHAR(20),
	currentLocation VARCHAR(50),
	destination VARCHAR(50),
	userLogTime DATETIME
)

CREATE PROC sp_AddUserLogs
	@utype VARCHAR(20),
	@start VARCHAR(50),
	@dest VARCHAR(50),
	@logTime DATETIME

AS
BEGIN
	INSERT INTO tblUserLogs
	VALUES (@utype, @start, @dest, @logTime)
END
GO

CREATE PROC sp_ViewSummaryAll
	@year INT,
	@month INT

AS
	SELECT * FROM tblUserLogs
	WHERE YEAR(userLogTime)=@year AND MONTH(userLogTime)=@month

GO

CREATE PROC sp_ViewSummaryByUserType
	@year INT,
	@month INT,
	@usertype VARCHAR(20)
AS
	SELECT * FROM tblUserLogs
	WHERE YEAR(userLogTime)=@year AND MONTH(userLogTime)=@month AND usertype=@usertype
GO