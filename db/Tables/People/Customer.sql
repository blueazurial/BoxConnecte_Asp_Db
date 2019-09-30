--Client
CREATE TABLE [dbo].[Customer]
(
	[Id] INT NOT NULL IDENTITY PRIMARY KEY REFERENCES [People](Id),
	--Code Client
	[CustomerCode] INT NOT NULL
)
