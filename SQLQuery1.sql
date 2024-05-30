CREATE TABLE [dbo].[YourTableName]
(
    [Id] INT IDENTITY(1,1) PRIMARY KEY,
    [Title] NVARCHAR(100),
    [Description] NVARCHAR(100),
    [Price] DECIMAL(18, 2),
    [CreatedAt] DATETIME
);
