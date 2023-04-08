ALTER TABLE [dbo].[tblResult]
	ADD CONSTRAINT [fk_tblResult_WinnerId]
	FOREIGN KEY (WinnerId)
	REFERENCES [tblPlayer] (Id)
