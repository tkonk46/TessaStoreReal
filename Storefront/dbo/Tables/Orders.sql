CREATE TABLE [dbo].[Orders] (
    [QuantityOrdered] INT            NULL,
    [ProductID]       INT            NULL,
    [ShippingAddress] NVARCHAR (350) NULL,
    [Total]           DECIMAL (18)   NULL,
    [DatePlaced]      DATETIME       DEFAULT (getdate()) NOT NULL,
    [OrderNumber]     INT            IDENTITY (100, 1) NOT NULL,
    [Name]            NVARCHAR (100) NULL,
    PRIMARY KEY CLUSTERED ([OrderNumber] ASC),
    FOREIGN KEY ([ProductID]) REFERENCES [dbo].[Products] ([ID])
);

