CREATE PROCEDURE usp_UserAccount_Update
@username VARCHAR(50),
@password VARCHAR(200), 
@name VARCHAR(100), 
@suername VARCHAR(100),
@roleId INT
AS
UPDATE dbo.UserAccount
SET Password=COALESCE(@password,@password),
Name=COALESCE(@name,Name),
Surname=COALESCE(@suername,Surname),
RoleId=COALESCE(@roleId,RoleId)
WHERE Username=@username