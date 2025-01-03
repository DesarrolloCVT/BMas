using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSap;

public partial class Ubvl
{
    public int AbsEntry { get; set; }

    public int? DocEntry { get; set; }

    public int? DocLineNum { get; set; }

    public int? DocType { get; set; }

    public int? BaseType { get; set; }

    public int? ActionType { get; set; }

    public int? AccumType { get; set; }

    public int? ManagedBy { get; set; }

    public DateTime? CreateDate { get; set; }

    public short? CreateTime { get; set; }

    public string? ItemCode { get; set; }

    public int? SysNumber { get; set; }

    public string? DistNumber { get; set; }

    public int? MdAbsEntry { get; set; }

    public string? TrValApply { get; set; }

    public decimal? TransValue { get; set; }

    public decimal? InvValue { get; set; }

    public decimal? CogsValue { get; set; }

    public decimal? Quantity { get; set; }

    public decimal? OverlapQty { get; set; }

    public decimal? CogsQty { get; set; }

    public decimal? CalcPrice { get; set; }

    public decimal? PriceDiff { get; set; }

    public decimal? InvDiff { get; set; }

    public decimal? Balance { get; set; }

    public decimal? AccTotal { get; set; }

    public decimal? AccQty { get; set; }

    public decimal? AccNegQ { get; set; }

    public int? Ilmentry { get; set; }

    public int? Itlentry { get; set; }

    public decimal? CostQty { get; set; }

    public decimal? Cost { get; set; }

    public int? BaseDocEn { get; set; }

    public int? BaseLnNum { get; set; }

    public decimal? DeltaAccT { get; set; }

    public int? RowAction { get; set; }
}
