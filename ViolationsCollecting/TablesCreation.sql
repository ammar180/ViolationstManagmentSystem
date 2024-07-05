CREATE TABLE [dbo].[Trucks] (
    [TruckId] INT           IDENTITY (1, 1) NOT NULL,
    [Code]    NVARCHAR (50) NOT NULL,
    CONSTRAINT [PK_Trucks] PRIMARY KEY CLUSTERED ([TruckId] ASC)
);


GO
CREATE UNIQUE NONCLUSTERED INDEX [IX_Trucks_Code]
    ON [dbo].[Trucks]([Code] ASC);


CREATE TABLE [dbo].[Violations] (
    [Id]              INT            IDENTITY (1, 1) NOT NULL,
    [ViolationDate]   DATE           NOT NULL,
    [Weight]          NVARCHAR (MAX) NULL,
    [Payload]         NVARCHAR (MAX) NULL,
    [ReportNumber]    NVARCHAR (MAX) NULL,
    [PaymentDate]     DATE           NULL,
    [TruckId]         INT            NOT NULL,
    [BlockDate]       DATE           NULL,
    [ResponsibleUnit] NCHAR (50)     NULL,
    [elManfath] NCHAR (50)     NULL,
    CONSTRAINT [PK_Violations] PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [FK_Violations_Trucks_TruckId] FOREIGN KEY ([TruckId]) REFERENCES [dbo].[Trucks] ([TruckId]) ON DELETE CASCADE
);


GO
CREATE NONCLUSTERED INDEX [IX_Violations_TruckId]
    ON [dbo].[Violations]([TruckId] ASC);

