CREATE PROCEDURE [dbo].[spLeaderboard]
AS
	SELECT p.Username, 
	gr.Turns Turns
	FROM tblPlayer p
	INNER JOIN tblGameResult gr on p.Id = gr.Id
RETURN 0