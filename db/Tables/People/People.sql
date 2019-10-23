--Personne
CREATE TABLE [dbo].[People]
(
	[ID] INT NOT NULL IDENTITY PRIMARY KEY,
	--Prenom
	[C_Nom] NVARCHAR(50) NOT NULL,
	--Nom
	[LastName] NVARCHAR(50) NOT NULL,
	[Email] NVARCHAR(100) NOT NULL,
	--Date d'anniversair
	[Birthdate] DATETIME2 NULL,
	[Gsm] INT NULL,
	[Password] varbinary (max) not null,
	[AddressId] INT NOT NULL REFERENCES [Address](Id)
	 
)
