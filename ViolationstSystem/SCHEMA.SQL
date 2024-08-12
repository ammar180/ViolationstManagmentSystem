CREATE TABLE [dbo].[Trucks] (
    [TruckCode]       NVARCHAR (128) NOT NULL,
    [IsExplored]      BIT            NULL,
    [ViolationsCount] INT            DEFAULT ((0)) NOT NULL,
    CONSTRAINT [PK_dbo.Trucks] PRIMARY KEY CLUSTERED ([TruckCode] ASC)
);

CREATE TABLE [dbo].[Users] (
    [Id]       INT            IDENTITY (1, 1) NOT NULL,
    [UserName] NVARCHAR (MAX) NULL,
    [Password] NVARCHAR (MAX) NULL,
    CONSTRAINT [PK_dbo.Users] PRIMARY KEY CLUSTERED ([Id] ASC)
);

CREATE TABLE [dbo].[Violations] (
    [Id]            INT            IDENTITY (1, 1) NOT NULL,
    [TruckCode]     NVARCHAR (128) NULL,
    [ViolationDate] DATETIME       NOT NULL,
    [Unit]          NVARCHAR (MAX) NOT NULL,
    [ElManfaz]      NVARCHAR (MAX) NOT NULL,
    [ReportNumber]  NVARCHAR (MAX) NULL,
    [PaymentDate]   NVARCHAR (MAX) NULL,
    [BlockDate]     NVARCHAR (MAX) NULL,
    CONSTRAINT [PK_dbo.Violations] PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [FK_dbo.Violations_dbo.Trucks_TruckCode] FOREIGN KEY ([TruckCode]) REFERENCES [dbo].[Trucks] ([TruckCode])
);


GO
CREATE NONCLUSTERED INDEX [IX_TruckCode]
    ON [dbo].[Violations]([TruckCode] ASC);

