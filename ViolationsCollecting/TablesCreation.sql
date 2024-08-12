CREATE TABLE [dbo].[Violations] (
    [Id]              INT            IDENTITY (1, 1) NOT NULL,
    [TruckCode]       NVARCHAR (64)  NOT NULL,
    [ViolationDate]   DATE           NOT NULL,
    [Unit] NCHAR (50)     NULL,
    [ElManfath] NCHAR (50)     NULL,
    
    --[Weight]          NVARCHAR (MAX) NULL,
    --[Payload]         NVARCHAR (MAX) NULL,
    
    --[ReportNumber]    NVARCHAR (MAX) NULL,
    --[PaymentDate]     DATE           NULL,
    --[BlockDate]       DATE           NULL,
    CONSTRAINT [PK_Violations] PRIMARY KEY CLUSTERED ([Id] ASC),
);
