CREATE TABLE [dbo].[LogTable]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [nom] VARCHAR(50) NOT NULL, 
    [valide] INT NOT NULL, 
    [codeE] INT NOT NULL, 
    [mError] VARCHAR(500) NOT NULL
)
