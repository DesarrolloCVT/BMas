using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSap;

public partial class B1InvPostListIlwithBinView
{
    public int? LogEntry { get; set; }

    public int? ApplyType { get; set; }

    public int? ApplyEntry { get; set; }

    public int? ApplyLine { get; set; }

    public int? AppSubLine { get; set; }

    public string? LocCode { get; set; }

    public string? ItemCode { get; set; }

    public int? ManagedBy { get; set; }

    public decimal? StockQty { get; set; }

    public int? MdAbsEntry { get; set; }

    public decimal? Quantity { get; set; }

    public decimal? TmpQty { get; set; }

    public int? AbsEntry { get; set; }

    public int? MessageId { get; set; }

    public int? BinAbs { get; set; }
}
