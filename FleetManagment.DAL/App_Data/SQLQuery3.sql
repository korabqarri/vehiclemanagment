CREATE PROCEDURE usp_UserAccount_GetById
@userId INT
AS
SELECT * FROM dbo.UserAccount AS ua WHERE ua.Id=@userId;