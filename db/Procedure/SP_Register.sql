
--Crée le user 
CREATE PROCEDURE [dbo].[SP_Register]
	@email NVARCHAR(255),
	@password NVARCHAR(255),
	@id INT 

AS
BEGIN
	INSERT INTO [People] (Email, [Password]) 
						VALUES (@email, dbo.Udf_hash_Password(@password, @email))

END