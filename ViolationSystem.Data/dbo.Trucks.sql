CREATE TABLE [dbo].[Trucks] (
    [TruckId] INT           IDENTITY (1, 1) NOT NULL,
    [Code]    NVARCHAR (50) NOT NULL,
    CONSTRAINT [PK_Trucks] PRIMARY KEY CLUSTERED ([TruckId] ASC)
);


GO
CREATE UNIQUE NONCLUSTERED INDEX [IX_Trucks_Code]
    ON [dbo].[Trucks]([Code] ASC);

