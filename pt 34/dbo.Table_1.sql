CREATE TABLE [dbo].[Table]
(
	[pid] INT NOT NULL PRIMARY KEY, 
    [pname] VARCHAR(50) NOT NULL, 
    [pqty] INT NOT NULL, 
    [pprice] INT NOT NULL, 
    [pdescription] VARCHAR(50) NULL, 
    [pcategory] VARCHAR(50) NOT NULL, 
)
