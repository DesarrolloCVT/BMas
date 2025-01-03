using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSap;

public partial class Ait8
{
    public string ItemCode { get; set; } = null!;

    public string PeriodCat { get; set; } = null!;

    public string DprArea { get; set; } = null!;

    public decimal? Apc { get; set; }

    public decimal? Apchist { get; set; }

    public decimal? Quantity { get; set; }

    public decimal? OrDpAcc { get; set; }

    public decimal? UnDpAcc { get; set; }

    public string? SpDpKey1 { get; set; }

    public decimal? SpDpAcc1 { get; set; }

    public string? SpDpKey2 { get; set; }

    public decimal? SpDpAcc2 { get; set; }

    public string? SpDpKey3 { get; set; }

    public decimal? SpDpAcc3 { get; set; }

    public int LogInstanc { get; set; }

    public string? ObjType { get; set; }

    public decimal? SalvageVal { get; set; }

    public decimal? OrDpAcc1 { get; set; }

    public decimal? WriteUpAcc { get; set; }

    public string? IsMaSalVal { get; set; }

    public decimal? AppreAcc { get; set; }
}
