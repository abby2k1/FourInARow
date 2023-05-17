﻿BEGIN 
	DECLARE @PlayerId uniqueidentifier;
	SELECT @PlayerId = Id from tblPlayer where Username = 'MaxWilke' 

	INSERT INTO DBO.tblResult (Id, WinnerId, LoserID, Turns)
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
	
	SELECT @PlayerId = Id from tblPlayer where Username = 'AbbieProudlock' 

	INSERT INTO DBO.tblResult (Id, WinnerId, LoserID, Turns)
	VALUES
	(NEWID(), @PlayerId, @PlayerId, 17)
	
	SELECT @PlayerId = Id from tblPlayer where Username = 'AbbieProudlock' 

	INSERT INTO DBO.tblResult (Id, WinnerId, LoserID, Turns)
	VALUES
	(NEWID(), @PlayerId, @PlayerId, 22) 
END