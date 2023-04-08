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
        public Color PlayerColor { get; set; }
        public Color OpponentColor { get; set; }
        public Color BoardColor { get; set; }
    }
}
