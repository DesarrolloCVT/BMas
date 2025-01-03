using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSap;

public partial class B1SnBopenQtyViewOrder
{
    public int? DocType { get; set; }

    public int? DocEntry { get; set; }

    public int? DocLine { get; set; }

    public int? DocSubLine { get; set; }

    public int? ManagedBy { get; set; }

    public string? ItemCode { get; set; }

    public int SysNumber { get; set; }

    public string? LocCode { get; set; }

    public decimal? Quantity { get; set; }
}
