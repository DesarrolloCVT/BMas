using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSap;

public partial class Oivq
{
    public int? TreeId { get; set; }

    public int? ParentId { get; set; }

    public short? LocType { get; set; }

    public string? LocCode { get; set; }

    public int TransSeq { get; set; }

    public int LayerId { get; set; }

    public decimal? OpenQty { get; set; }

    public decimal? OpenValue { get; set; }

    public string? ItemCode { get; set; }

    public int AbsEntry { get; set; }

    public int? StockActio { get; set; }

    public string? RemMethod { get; set; }
}
