using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSap;

public partial class Far1
{
    public int DocEntry { get; set; }

    public int LineNum { get; set; }

    public string? ItemCode { get; set; }

    public decimal? Nbv { get; set; }

    public decimal? NewNbv { get; set; }

    public string? Remarks { get; set; }

    public decimal? RevalPerc { get; set; }

    public decimal? OrdDprDur { get; set; }

    public decimal? UnDpDur { get; set; }

    public decimal? SpDprDur { get; set; }

    public decimal? WriteUpDur { get; set; }
}
