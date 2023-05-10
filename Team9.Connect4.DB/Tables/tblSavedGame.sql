﻿CREATE TABLE [dbo].[tblSavedGame]
(
	[Id] UNIQUEIDENTIFIER NOT NULL PRIMARY KEY, 
    [ResultsId] UNIQUEIDENTIFIER, 
    [Player1Id] UNIQUEIDENTIFIER NOT NULL, 
    [Player2Id] UNIQUEIDENTIFIER NOT NULL, 
    [BoardState] NVARCHAR(MAX) NOT NULL, 
    [GameCode] NCHAR(10) NOT NULL
)
