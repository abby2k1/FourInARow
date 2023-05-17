CREATE PROCEDURE [dbo].[spLeaderboard]
AS
	SELECT r.Turns, 
	p.Username AS Winner
	FROM tblSavedGame sg
	INNER JOIN tblPlayer p on sg.Player2Id = p.Id
	INNER JOIN tblResult r ON sg.ResultsId = r.Id
	WHERE r.Turns <= 12
RETURN