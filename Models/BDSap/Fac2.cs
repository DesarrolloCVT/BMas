using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSap;

public partial class Fac2
{
    public int AbsEntry { get; set; }

    public int LineNum { get; set; }

    public string DprArea { get; set; } = null!;

    public string PeriodCat { get; set; } = null!;

    public int VisOrder { get; set; }

    public string? OldDprSt { get; set; }

    public string? NewDprSt { get; set; }

    public decimal? OldFactor { get; set; }

    public decimal? NewFactor { get; set; }
}
