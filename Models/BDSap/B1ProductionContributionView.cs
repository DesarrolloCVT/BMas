using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSap;

public partial class B1ProductionContributionView
{
    public int QueryType { get; set; }

    public string Contribution { get; set; } = null!;

    public string? AppObjType { get; set; }

    public string IsInventory { get; set; } = null!;

    public int? Wor { get; set; }

    public int? TransType { get; set; }

    public int? DocEntry { get; set; }

    public int? DocLineNum { get; set; }

    public int MessageId { get; set; }

    public int? LineId { get; set; }

    public int? Poline { get; set; }

    public int? ItemType { get; set; }

    public string? ItemCode { get; set; }

    public string? LocCode { get; set; }

    public decimal? Quantity { get; set; }

    public decimal? TotalLc { get; set; }

    public decimal? PriceDiff { get; set; }

    public decimal? NegInvAdjs { get; set; }

    public int? BaseType { get; set; }

    public int? BaseAbsEnt { get; set; }

    public int? BaseLine { get; set; }

    public int? LayerTseq { get; set; }

    public int? LayerId { get; set; }

    public string? EvalSystem { get; set; }

    public string? ItemName { get; set; }
}
