using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Team9.Connect4.BL.Models
{
    public class SavedGame
    {
        public Guid Id { get; set; }
        public Guid? ResultsId { get; set; } = null!;

        public Guid Player1Id { get; set; }

        public Guid Player2Id { get; set; }

        public string BoardState { get; set; } = null!;

        public string GameCode { get; set; } = null!;
    }

}
