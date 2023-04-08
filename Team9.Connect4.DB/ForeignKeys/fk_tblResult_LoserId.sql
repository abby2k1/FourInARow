ALTER TABLE [dbo].[tblResult]
	ADD CONSTRAINT [fk_tblResult_LoserId]
	FOREIGN KEY (LoserId)
	REFERENCES [tblPlayer] (Id)
