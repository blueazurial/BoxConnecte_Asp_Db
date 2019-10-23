--Commande
CREATE TABLE [dbo].[Order]
(
	[ID] INT NOT NULL IDENTITY PRIMARY KEY,
	[Description] NVARCHAR(255) NULL,
	[QrCode] INT  NULL,
	[NumberBox] INT NULL,
	--commande retirée
	[OrderWithdrawn] BIT NOT NULL DEFAULT 0,
	[PswBox] int null

	
	

)
