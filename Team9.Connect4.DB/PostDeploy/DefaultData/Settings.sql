BEGIN
	INSERT INTO dbo.tblSetting (Id, PlayerColor, OpponentColor, BoardColor)
	VALUES
	(NEWID(), '0000FF', 'FF0000', '33CC33'),
	(NEWID(), '00FF00', 'FFFF00', '3333CC'),
	(NEWID(), 'FF00FF', '00FFFF', '666666')
END
