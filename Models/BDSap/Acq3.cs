using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSap;

public partial class Acq3
{
    public int DocEntry { get; set; }

    public int ItemLine { get; set; }

    public string? ItemCode { get; set; }

    public string DprArea { get; set; } = null!;

    public decimal? Total { get; set; }

    public decimal? TotalFrgn { get; set; }

    public decimal? TotalSys { get; set; }

    public string? ObjType { get; set; }

    public int? LogInstanc { get; set; }
}
