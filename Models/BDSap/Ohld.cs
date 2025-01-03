using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSap;

public partial class Ohld
{
    public string HldCode { get; set; } = null!;

    public string? WndFrm { get; set; }

    public string? WndTo { get; set; }

    public string? IsCurYear { get; set; }

    public string? IgnrWnd { get; set; }

    public string? WeekNoRule { get; set; }
}
