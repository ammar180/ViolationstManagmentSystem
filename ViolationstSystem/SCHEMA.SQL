CREATE TABLE [dbo].[Users] (
    [Id]       INT            IDENTITY (1, 1) NOT NULL,
    [UserName] NVARCHAR (MAX) NULL,
    [Password] NVARCHAR (MAX) NULL,
    CONSTRAINT [PK_dbo.Users] PRIMARY KEY CLUSTERED ([Id] ASC)
);


CREATE TABLE [dbo].[Trucks] (
    [TruckCode]  NVARCHAR (128) NOT NULL,
    [IsExplored] BIT            NOT NULL,
    CONSTRAINT [PK_dbo.Trucks] PRIMARY KEY CLUSTERED ([TruckCode] ASC)
);

CREATE TABLE [dbo].[Violations] (
    [Id]            INT            IDENTITY (1, 1) NOT NULL,
    [TruckCode]     NVARCHAR (128) NOT NULL,
    [ViolationDate] DATETIME       NOT NULL,
    [Unit]          NVARCHAR (64)  NOT NULL,
    [ElManfaz]      NVARCHAR (64)  NULL,
    [ReportNumber]  NVARCHAR (128) NULL,
    [BlockDate]     DATETIME       NULL,
    [PaymentDate]   DATETIME       NULL,
    [Comments]      NVARCHAR (MAX) NULL,
    [VCount]        NVARCHAR (MAX) NULL,
    CONSTRAINT [PK_dbo.Violations] PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [FK_dbo.Violations_dbo.Trucks_TruckCode] FOREIGN KEY ([TruckCode]) REFERENCES [dbo].[Trucks] ([TruckCode]) ON DELETE CASCADE
);


GO
CREATE NONCLUSTERED INDEX [IX_TruckCode]
    ON [dbo].[Violations]([TruckCode] ASC);

