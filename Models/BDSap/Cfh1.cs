using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSap;

public partial class Cfh1
{
    public int Cfhid { get; set; }

    public int LineId { get; set; }

    public string? DispItem { get; set; }

    public short? Levels { get; set; }

    public string? LineNum { get; set; }

    public string? IndentChar { get; set; }

    public decimal? Amount { get; set; }

    public string? Formula { get; set; }
}
