using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSap;

public partial class Hmm1
{
    public int DocEntry { get; set; }

    public int LineNum { get; set; }

    public string? ViewType { get; set; }

    public string ViewName { get; set; } = null!;

    public string? MenuDesc { get; set; }

    public string? MenuEnable { get; set; }

    public string? Iaenable { get; set; }

    public string? Slenable { get; set; }

    public string? Slexpose { get; set; }
}
