CREATE TABLE [dbo].[Table]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [model] NVARCHAR(50) NULL, 
    [processor] NVARCHAR(50) NULL, 
    [ran] INT NULL, 
    [hhd] INT NULL, 
    [prise] MONEY NULL
)
