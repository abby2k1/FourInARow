BEGIN
	DECLARE @SettingsId uniqueidentifier;
	SELECT @SettingsId = Id from tblSetting where PlayerColor = '#00FF00' 

	INSERT INTO dbo.tblPlayer (Id, Username, Password, SettingId)
	VALUES
	(NEWID(), 'MaxWilke', 'Maple', @SettingsId)

	SELECT @SettingsId = Id from tblSetting where PlayerColor = '#FF0000' 

	INSERT INTO dbo.tblPlayer (Id, Username, Password, SettingId)
	VALUES
	(NEWID(), 'AbbyThompson', 'Maple', @SettingsId)

	SELECT @SettingsId = Id from tblSetting where PlayerColor = '#0000FF' 

	INSERT INTO dbo.tblPlayer (Id, Username, Password, SettingId)
	VALUES
	(NEWID(), 'AbbieProudlock', 'Maple', @SettingsId)
END