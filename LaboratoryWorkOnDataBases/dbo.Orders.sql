CREATE TABLE [dbo].[Orders] (
    [Id]                    INT             IDENTITY (1, 1) NOT NULL,
    [Price]                 DECIMAL (18, 2) NULL,
    [DateTime]              DATETIME2 (7)   NULL,
    [CustomerId]            INT             NULL,
    [ConstructionCompanyId] INT             NULL,
    CONSTRAINT [PK_Orders] PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [FK_Orders_ConstructionCompanies_ConstructionCompanyId] FOREIGN KEY ([ConstructionCompanyId]) REFERENCES [dbo].[ConstructionCompanies] ([Id]) ON DELETE CASCADE,
    CONSTRAINT [FK_Orders_Customers_CustomerId] FOREIGN KEY ([CustomerId]) REFERENCES [dbo].[Customers] ([Id]) ON DELETE CASCADE
);


GO
CREATE NONCLUSTERED INDEX [IX_Orders_ConstructionCompanyId]
    ON [dbo].[Orders]([ConstructionCompanyId] ASC);


GO
CREATE NONCLUSTERED INDEX [IX_Orders_CustomerId]
    ON [dbo].[Orders]([CustomerId] ASC);


GO
CREATE TRIGGER Products_INSERT_UPDATE
ON dbo.Orders
AFTER INSERT, UPDATE
AS
UPDATE Orders
SET Price = Price + Price * 0.38
WHERE Id = (SELECT Id FROM inserted)