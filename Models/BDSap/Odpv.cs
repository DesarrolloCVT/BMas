using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSap;

public partial class Odpv
{
    public int AbsEntry { get; set; }

    public string ItemCode { get; set; } = null!;

    public string DprArea { get; set; } = null!;

    public string PeriodCat { get; set; } = null!;

    public DateTime? FromDate { get; set; }

    public DateTime? ToDate { get; set; }

    public decimal? OrdDprPlan { get; set; }

    public decimal? OrdDprPost { get; set; }

    public decimal? OrdDprAct { get; set; }

    public string? SpDprKey { get; set; }

    public decimal? SpDprPlan { get; set; }

    public decimal? SpDprPost { get; set; }

    public decimal? SpDprAct { get; set; }

    public int SubPeriod { get; set; }

    public decimal? OrdDprPln1 { get; set; }

    public decimal? OrdDprPst1 { get; set; }

    public decimal? OrdDprAct1 { get; set; }
}
