CREATE TABLE [dbo].[Trucks] (
    [TruckCode]    NVARCHAR (50) NOT NULL,
    [IsExplored]    BIT NULL,
    CONSTRAINT [PK_Trucks] PRIMARY KEY CLUSTERED ([TruckCode] ASC)
);


GO
CREATE UNIQUE NONCLUSTERED INDEX [IX_Trucks_Code]
    ON [dbo].[Trucks]([Code] ASC);

