
--Crée le user 
CREATE PROCEDURE [dbo].[SP_Register]
	@email NVARCHAR(100),
	@password NVARCHAR(255),
	@id INT ,
	@c_nom NVARCHAR(50),
	@lastName NVARCHAR(50),
	@birthdate DATETIME,
	@gsm INT,
	@addressid INT

AS
BEGIN
	INSERT INTO People(C_Nom,LastName,Email,Birthdate,Gsm,[Password],AddressId)
	OUTPUT inserted.id 
	VALUES (@c_nom,@lastName,@email,@birthdate,@gsm,dbo.Udf_Hash_Password(@password,@email),@addressid)

END