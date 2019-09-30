--Personne
CREATE TABLE [dbo].[People]
(
	[Id] INT NOT NULL IDENTITY PRIMARY KEY,
	--Prenom
	[FirstName] NVARCHAR(50) NOT NULL,
	--Nom
	[LastName] NVARCHAR(50) NOT NULL,
	[Email] NVARCHAR(100) NOT NULL,
	--Date d'anniversair
	[Birthdate] DATETIME2 NULL,
	[Gsm] INT NULL,
	[AddressId] INT NOT NULL REFERENCES [Address](Id)
	 
)
