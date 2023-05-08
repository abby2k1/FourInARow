BEGIN 
	DECLARE @ResultsId uniqueidentifier;
	DECLARE @Player1Id uniqueidentifier;
	DECLARE @Player2Id uniqueidentifier;

	SELECT @ResultsId = Id from tblResult where Turns = 10 
	SELECT @Player1Id = Id from tblPlayer where Username = 'AbbyThompson'
	SELECT @Player2Id = Id from tblPlayer where Username = 'AbbieProudlock'

	INSERT INTO DBO.tblSavedGame(Id, ResultsId, Player1Id, Player2Id, BoardState)
	VALUES
	(NEWID(), @ResultsId, @Player1Id, @Player2Id, '00000000000000000000000000000000000000121200000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000')
	
	SELECT @ResultsId = Id from tblResult where Turns = 12 
	SELECT @Player1Id = Id from tblPlayer where Username = 'AbbyThompson'
	SELECT @Player2Id = Id from tblPlayer where Username = 'MaxWilke'

	INSERT INTO DBO.tblSavedGame(Id, ResultsId, Player1Id, Player2Id, BoardState)
	VALUES
	(NEWID(), @ResultsId, @Player1Id, @Player2Id, '00000000000000000000000000000000000000121200000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000')

	SELECT @ResultsId = Id from tblResult where Turns = 14 
	SELECT @Player1Id = Id from tblPlayer where Username = 'MaxWilke'
	SELECT @Player2Id = Id from tblPlayer where Username = 'AbbieProudlock'

	INSERT INTO DBO.tblSavedGame(Id, ResultsId, Player1Id, Player2Id, BoardState)
	VALUES
	(NEWID(), @ResultsId, @Player1Id, @Player2Id, '00000000000000000000000000000000000000121200000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000')
END