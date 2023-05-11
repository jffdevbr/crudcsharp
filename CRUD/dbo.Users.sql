CREATE TABLE [dbo].[Table]
(
	[Register_ID] INT NOT NULL PRIMARY KEY IDENTITY, 
    [Nickname] NVARCHAR(50) NULL,
	[Name] NVARCHAR(50) NULL, 
	[Birthdate] DATE NULL, 
    [Age] INT NULL, 
    [Email] NVARCHAR(50) NULL, 
    [Favorite Color] NVARCHAR(50) NULL, 
    [Studying] BIT NULL
    
)
