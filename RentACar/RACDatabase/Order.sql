CREATE TABLE [dbo].[Order]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [Car_id] NCHAR(10) NULL, 
    [Customer] NCHAR(10) NULL, 
    [Date] DATETIME NULL 
)
