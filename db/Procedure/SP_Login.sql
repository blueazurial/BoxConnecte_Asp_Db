--connection d un user 
--fonction enregister sur le serveur qui peux etre appler de l'exterieur 

CREATE PROCEDURE [dbo].[SP_Login]
	@email NVARCHAR(255),
	@password NVARCHAR(255)
AS
BEGIN
	SELECT Email,ID as [Password] FROM [People] WHERE Email = @email AND [Password] = dbo.Udf_Hash_Password (@password, @email)
END
