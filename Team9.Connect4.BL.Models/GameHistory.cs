using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Team9.Connect4.BL.Models
{
    public class GameHistory
    {
        public Guid Results { get; set; }
        public string Player1Username { get; set; }
        public string Player2Username { get; set;}
        public string BoardState { get; set;}
        public string GameCode { get; set;}
        public int Turns { get; set;}
    }
}
