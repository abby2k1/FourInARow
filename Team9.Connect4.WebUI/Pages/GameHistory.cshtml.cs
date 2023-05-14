using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Data.SqlClient;
using Team9.Connect4.BL.Models;
using System.Data;

namespace Team9.Connect4.WebUI.Pages.Shared
{
    public class GameHistoryModel : PageModel
    {
        public List<GameHistory> GetGameHistory()
        {
            List<GameHistory> gameHistories = new List<GameHistory>();
            using (SqlConnection conn = new SqlConnection 
                ("Server=tcp:wilkedb.database.windows.net,1433;Initial Catalog=wilkedb;Persist Security Info=False;User ID=wilkedb;Password=Test123!;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;"))
            {
                conn.Open();

                SqlCommand sqlCommand = new SqlCommand("spGameHistory", conn);
                sqlCommand.CommandType = CommandType.StoredProcedure;

                SqlDataReader dataReader = sqlCommand.ExecuteReader();

                while (dataReader.Read())
                {
                    GameHistory gameHistory = new GameHistory();
                    gameHistory.Results = dataReader.GetGuid(0);
                    gameHistory.Player1Username = dataReader.GetString(1);
                    gameHistory.Player2Username = dataReader.GetString(2);
                    gameHistory.BoardState = dataReader.GetString(3);
                    gameHistory.GameCode = dataReader.GetString(4);
                    gameHistory.Turns = dataReader.GetInt32(5);

                    gameHistories.Add(gameHistory);
                }
            }
            return gameHistories;
        }

        public void OnGet()
        {
        }
    }
}
