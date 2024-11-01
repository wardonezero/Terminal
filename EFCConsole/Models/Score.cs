using System;
using System.Collections.Generic;

namespace EFCConsole.Models;

public partial class Score
{
    public string Testid { get; set; } = null!;

    public string Studentid { get; set; } = null!;

    public byte Score1 { get; set; }

    public virtual Test Test { get; set; } = null!;
}
