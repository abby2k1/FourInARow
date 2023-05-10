using System;
using System.Collections.Generic;

namespace Team9.Connect4.PL;

public partial class tblSavedGame
{
    public Guid Id { get; set; }

    public Guid? ResultsId { get; set; } = null!;

    public Guid Player1Id { get; set; }

    public Guid Player2Id { get; set; }

    public string BoardState { get; set; } = null!;

    public string GameCode { get; set; } = null!;
}
