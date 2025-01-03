using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSap;

public partial class Ais2
{
    public int DocEntry { get; set; }

    public int LineNum { get; set; }

    public int TargetLoc { get; set; }

    public string? TarLocName { get; set; }

    public int TarStaType { get; set; }

    public string TarTaxAcct { get; set; } = null!;

    public decimal? AllocAmnt { get; set; }

    public string? Itctype { get; set; }
}
