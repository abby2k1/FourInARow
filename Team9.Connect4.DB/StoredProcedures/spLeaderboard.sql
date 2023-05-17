CREATE PROCEDURE [dbo].[spLeaderboard]
AS
	SELECT r.Turns, 
	p.Username AS Username
	FROM tblResult r
	INNER JOIN tblPlayer p on r.Id = p.Id
	WHERE r.Turns <= 12
RETURN