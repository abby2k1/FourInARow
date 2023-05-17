using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Data.SqlClient;
using Team9.Connect4.PL;
using System.Data;

namespace Team9.Connect4.WebUI.Pages.Shared
{
    public class LeaderboardModel : PageModel
    {
        public List<spLeaderboardResult> GetLeaderboard()
        {
            List<spLeaderboardResult> leaderboards = new List<spLeaderboardResult>();

            using (SqlConnection conn = new SqlConnection
                ("Server=tcp:wilkedb.database.windows.net,1433;Initial Catalog=wilkedb;Persist Security Info=False;User ID=wilkedb;Password=Test123!;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;"))
            {
                conn.Open();

                SqlCommand sqlCommand = new SqlCommand("spLeaderboard", conn);
                sqlCommand.CommandType = CommandType.StoredProcedure;

                SqlDataReader dataReader = sqlCommand.ExecuteReader();

                while (dataReader.Read())
                {
                    spLeaderboardResult leaderboard = new spLeaderboardResult();
                    leaderboard.Winner = dataReader.GetString(1);
                    leaderboard.Turns = dataReader.GetInt32(0);

                    leaderboards.Add(leaderboard);
                }
            }
            return leaderboards;
        }

        public void OnGet()
        {
        }
    }
}
