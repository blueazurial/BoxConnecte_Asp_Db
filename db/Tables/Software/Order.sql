--Commande
CREATE TABLE [dbo].[Order]
(
	[Id] INT NOT NULL IDENTITY PRIMARY KEY,
	[Description] NVARCHAR(255) NULL,
	[QrCode] INT NOT NULL,
	[DigiCode] INT NOT NULL,
	--date de la livraison
	[DateDelivery] DATETIME2  NULL,
	[DateLimite] DATETIME2  NULL,
	[CustumerId] INT NOT NULL REFERENCES [Customer](Id),
	[SellerId] INT NULL REFERENCES [Seller](Id), 
	
	[OrderStatusId] INT NOT NULL REFERENCES [OrderStatus](Id)

	

)
