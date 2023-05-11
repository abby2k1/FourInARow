using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Data.SqlClient;
using Team9.Connect4.BL.Models;
using System.Data;

namespace Team9.Connect4.WebUI.Pages.Shared
{
    public class LeaderboardModel : PageModel
    {
        public List<Leaderboard> GetLeaderboard()
        {
            List<Leaderboard> leaderboards = new List<Leaderboard>();

            using (SqlConnection conn = new SqlConnection("Server=(localhost)\\MSSQLLocalDB;Database=Team9.Connect4.DB;Integrated Security=true"))
            {
                conn.Open();

                SqlCommand sqlCommand = new SqlCommand("spLeaderboard", conn);
                sqlCommand.CommandType = CommandType.StoredProcedure;

                SqlDataReader dataReader = sqlCommand.ExecuteReader();

                while (dataReader.Read())
                {
                    Leaderboard leaderboard = new Leaderboard();
                    leaderboard.Winner = dataReader.GetString(0);
                    leaderboard.Turns = dataReader.GetInt32(1);

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
