CREATE PROCEDURE [dbo].[spLeaderboard]
AS
	SELECT r.Turns, 
	p.Username AS Winner
	FROM tblResult r
	INNER JOIN tblPlayer p on r.Id = p.Id
	WHERE r.Turns <= 12
RETURN