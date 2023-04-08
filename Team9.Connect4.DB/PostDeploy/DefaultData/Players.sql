BEGIN
	DECLARE @SettingsId uniqueidentifier;
	SELECT @SettingsId = Id from tblSetting where PlayerColor = 'Green' 

	INSERT INTO dbo.tblPlayer (Id, Username, Password, SettingId)
	VALUES
	(NEWID(), 'MaxWilke', 'Maple', @SettingsId)

	SELECT @SettingsId = Id from tblSetting where PlayerColor = 'Red' 

	INSERT INTO dbo.tblPlayer (Id, Username, Password, SettingId)
	VALUES
	(NEWID(), 'AbbyThompson', 'Maple', @SettingsId)

	SELECT @SettingsId = Id from tblSetting where PlayerColor = 'Blue' 

	INSERT INTO dbo.tblPlayer (Id, Username, Password, SettingId)
	VALUES
	(NEWID(), 'AbbieProudlock', 'Maple', @SettingsId)
END