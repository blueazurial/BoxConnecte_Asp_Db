﻿--Vendeur
CREATE TABLE [dbo].[Seller]
(

	[Id] INT NOT NULL IDENTITY PRIMARY KEY REFERENCES [People](Id)
)
