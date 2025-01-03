using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSap;

public partial class Ait11
{
    public string ItemCode { get; set; } = null!;

    public string PeriodCat { get; set; } = null!;

    public string DprArea { get; set; } = null!;

    public int VisOrder { get; set; }

    public string? DprSt { get; set; }

    public decimal? Factor { get; set; }

    public int LogInstanc { get; set; }

    public int? ActualUnit { get; set; }
}
