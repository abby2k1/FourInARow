using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Team9.Connect4.BL.Models
{
    public class Setting
    {
        public Guid Id { get; set; }
        public String? PlayerColor { get; set; }
        public String? OpponentColor { get; set; }
        public String? BoardColor { get; set; }
    }
}
