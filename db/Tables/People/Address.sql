--Adresse
CREATE TABLE [dbo].[Address]
(
	[ID] INT NOT NULL IDENTITY PRIMARY KEY,
	[Number] INT NULL ,
	--Rue
	[Street] NVARCHAR(200) NOT NULL ,
	[PostalCode] INT NOT NULL ,
	--Ville
	[City] NVARCHAR(50) NOT NULL ,

)
