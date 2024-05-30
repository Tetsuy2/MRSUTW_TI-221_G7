CREATE TABLE [dbo].[Trips] (
    [Id]          INT             IDENTITY (1, 1) NOT NULL,
    [Title]       NVARCHAR (100)  NULL,
    [Description] NVARCHAR (100)  NULL,
    [Price]       DECIMAL (18, 2) NULL,
    [CreatedAt]   DATETIME        NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC)
);

