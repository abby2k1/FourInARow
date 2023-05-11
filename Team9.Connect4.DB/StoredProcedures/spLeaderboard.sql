CREATE PROCEDURE [dbo].[spLeaderboard]
AS
	SELECT r.Turns, 
	p.Username Username
	FROM tblResult r
	INNER JOIN tblPlayer p on r.Id = p.Id
RETURN