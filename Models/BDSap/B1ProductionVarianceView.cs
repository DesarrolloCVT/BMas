using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSap;

public partial class B1ProductionVarianceView
{
    public int? Wor { get; set; }

    public string? AppObjType { get; set; }

    public string? ItemCode { get; set; }

    public string? ItemName { get; set; }

    public string IsInventory { get; set; } = null!;

    public int? ItemType { get; set; }

    public decimal? Quantity { get; set; }

    public decimal? RealTransaction { get; set; }

    public decimal? OpenPriceDiff { get; set; }

    public decimal? OpenNegInv { get; set; }

    public decimal? UsedForParent { get; set; }

    public decimal Variance { get; set; }

    public string? EvalSystem { get; set; }
}
