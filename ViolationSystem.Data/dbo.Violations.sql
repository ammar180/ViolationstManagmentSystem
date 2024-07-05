CREATE TABLE [dbo].[Violations] (
    [Id]            INT            IDENTITY (1, 1) NOT NULL,
    [ViolationDate] DATE           NOT NULL,
    [Weight]        NVARCHAR (MAX) NULL,
    [Payload]       NVARCHAR (MAX) NULL,
    [ReportNumber]  NVARCHAR (MAX) NULL,
    [PaymentDate]   DATE           NULL,
    [TruckId]       INT            NOT NULL,
    CONSTRAINT [PK_Violations] PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [FK_Violations_Trucks_TruckId] FOREIGN KEY ([TruckId]) REFERENCES [dbo].[Trucks] ([TruckId]) ON DELETE CASCADE
);


GO
CREATE NONCLUSTERED INDEX [IX_Violations_TruckId]
    ON [dbo].[Violations]([TruckId] ASC);

