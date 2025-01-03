using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSap;

public partial class B1SnBopenQtyInnerView
{
    public int? ApplyType { get; set; }

    public int? ApplyEntry { get; set; }

    public int? ApplyLine { get; set; }

    public int? AppSubLine { get; set; }

    public int? ManagedBy { get; set; }

    public int LogEntry { get; set; }

    public string? ItemCode { get; set; }

    public int SysNumber { get; set; }

    public string? LocCode { get; set; }

    public int? TransId { get; set; }

    public decimal? Quantity { get; set; }
}
