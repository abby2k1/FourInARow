BEGIN
	INSERT INTO dbo.tblSetting (Id, PlayerColor, OpponentColor, BoardColor)
	VALUES
	(NEWID(), 'Blue', 'Red', 'Black'),
	(NEWID(), 'Green', 'Orange', 'White'),
	(NEWID(), 'Purple', 'Green', 'Grey')
END
