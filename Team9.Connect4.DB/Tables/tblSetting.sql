﻿CREATE TABLE [dbo].[tblSetting]
(
	[Id] UNIQUEIDENTIFIER NOT NULL PRIMARY KEY,
	[PlayerColor] NVARCHAR(MAX) NOT NULL,
	[OpponentColor] NVARCHAR(MAX) NOT NULL,
	[BoardColor] NVARCHAR(MAX) NOT NULL
)
