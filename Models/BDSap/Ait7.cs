using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSap;

public partial class Ait7
{
    public string ItemCode { get; set; } = null!;

    public string PeriodCat { get; set; } = null!;

    public string DprArea { get; set; } = null!;

    public int? VisOrder { get; set; }

    public DateTime? DprStart { get; set; }

    public DateTime? DprEnd { get; set; }

    public int? UsefulLife { get; set; }

    public decimal? RemainLife { get; set; }

    public string? DprType { get; set; }

    public string? DprTypeC { get; set; }

    public int? UsefulLfeC { get; set; }

    public int LogInstanc { get; set; }

    public string? ObjType { get; set; }

    public decimal? RemainDays { get; set; }

    public int? TotalUnits { get; set; }

    public int? RemainUnit { get; set; }

    public int? StanUnit { get; set; }
}
