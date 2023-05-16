using System;
using System.Collections.Generic;

namespace Team9.Connect4.PL;

public partial class tblResult
{
    public Guid Id { get; set; }

    public Guid? WinnerId { get; set; }

    public Guid? LoserID { get; set; }

    public int Turns { get; set; }

    public virtual tblPlayer? Loser { get; set; }

    public virtual tblPlayer? Winner { get; set; }

    public virtual ICollection<tblSavedGame> tblSavedGames { get; set; } = new List<tblSavedGame>();
}
