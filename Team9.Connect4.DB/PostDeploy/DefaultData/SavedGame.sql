BEGIN 
	DECLARE @ResultsId uniqueidentifier;
	SELECT @PlayerId = Id from tblPlayer where Username = 'MaxWilke' 

	INSERT INTO DBO.tbtblSavedGame(Id, ResultsId, Player1ID, Player2ID, BoardState)
	VALUES
	(NEWID(), @PlayerId, @PlayerId, 12)
	
	SELECT @PlayerId = Id from tblPlayer where Username = 'AbbyThompson' 

	INSERT INTO DBO.tblResult (Id, WinnerId, LoserID, Turns)
	VALUES
	(NEWID(), @PlayerId, @PlayerId, 14) 

	SELECT @PlayerId = Id from tblPlayer where Username = 'AbbieProudlock' 

	INSERT INTO DBO.tblResult (Id, WinnerId, LoserID, Turns)
	VALUES
	(NEWID(), @PlayerId, @PlayerId, 10) 
END