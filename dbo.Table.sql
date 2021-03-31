CREATE TABLE [dbo].[Table]
(
    [ProductID] INT NOT NULL IDENTITY, 
    [ProductType] INT NOT NULL, 
    [Description] NVARCHAR(MAX) NOT NULL, 
    [Price] MONEY NOT NULL, 
    [Image] IMAGE NOT NULL, 
    PRIMARY KEY ([ProductID])
)
