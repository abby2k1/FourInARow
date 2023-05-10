ALTER TABLE dbo.tblSavedGame
	ADD CONSTRAINT [fk_tblSavedGame_ResultsId]
	FOREIGN KEY (ResultsId)
	REFERENCES tblResult (Id)
