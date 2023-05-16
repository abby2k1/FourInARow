CREATE PROCEDURE [dbo].[spGameHistory]
AS
BEGIN
	SELECT
		player1.Username AS Player1Username,
		player2.Username AS Player2Username,
		sg.BoardState,
		sg.GameCode,
		r.Turns
	FROM
		tblSavedGame sg
		INNER JOIN tblPLayer player1 ON sg.Player1Id = player1.Id
		INNER JOIN tblPlayer player2 ON sg.Player2Id = player2.Id
		INNER JOIN tblResult r ON sg.ResultsId = r.Id
END