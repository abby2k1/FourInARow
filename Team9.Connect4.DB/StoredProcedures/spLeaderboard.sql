CREATE PROCEDURE [dbo].[spLeaderboard]
AS
	SELECT r.Turns, 
	p.Username AS Winner
	FROM tblResult r
	INNER JOIN tblSavedGame sg ON r.Id = sg.ResultsId
	INNER JOIN tblPlayer p ON sg.Player2Id = p.Id
	WHERE r.Turns <= 12
RETURN

