ALTER TABLE [dbo].[tblPlayer]
	ADD CONSTRAINT [fk_tblPlayer_SettingId]
	FOREIGN KEY (SettingId)
	REFERENCES [tblSetting] (Id)
