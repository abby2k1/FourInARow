using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Team9.Connect4.BL.Models
{
    public class Game
    {
        public Guid Id { get; set; }
        public Guid WinnerId { get; set; }
        public Guid LoserId { get; set; }
        public int Turns { get; set; }
    }
}
