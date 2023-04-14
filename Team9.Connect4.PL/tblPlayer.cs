using System;
using System.Collections.Generic;

namespace Team9.Connect4.PL;

public partial class tblPlayer
{
    public Guid Id { get; set; }

    public string Username { get; set; } = null!;

    public string Password { get; set; } = null!;

    public Guid SettingId { get; set; }

    public virtual tblSetting Setting { get; set; } = null!;

    public virtual ICollection<tblResult> tblResultLosers { get; set; } = new List<tblResult>();

    public virtual ICollection<tblResult> tblResultWinners { get; set; } = new List<tblResult>();
}
