using System;
using System.Collections.Generic;

namespace Team9.Connect4.PL;

public partial class tblSetting
{
    public Guid Id { get; set; }

    public string PlayerColor { get; set; } = null!;

    public string OpponentColor { get; set; } = null!;

    public string BoardColor { get; set; } = null!;

    public virtual ICollection<tblPlayer> tblPlayers { get; set; } = new List<tblPlayer>();
}
