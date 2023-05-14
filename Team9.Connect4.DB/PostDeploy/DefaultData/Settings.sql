BEGIN
	INSERT INTO dbo.tblSetting (Id, PlayerColor, OpponentColor, BoardColor)
	VALUES
	(NEWID(), '0000FF', 'FF0000', '000000'),
	(NEWID(), '00FF00', 'FFFF00', 'FFFFFF'),
	(NEWID(), 'FF00FF', '00FF00', '666666')
END
