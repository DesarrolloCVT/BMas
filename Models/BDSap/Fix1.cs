using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSap;

public partial class Fix1
{
    public int AbsEntry { get; set; }

    public int LineNum { get; set; }

    public string? ItemCode { get; set; }

    public string? DprArea { get; set; }

    public string? PeriodCat { get; set; }

    public int? PostPeriod { get; set; }

    public DateTime? RefDate { get; set; }

    public decimal? Apc { get; set; }

    public decimal? OrdDpr { get; set; }

    public decimal? UnpDpr { get; set; }

    public string? SpDprKey1 { get; set; }

    public decimal? SpDpr1 { get; set; }

    public decimal? Qty { get; set; }

    public string? DprType { get; set; }

    public DateTime? DprDate { get; set; }

    public int? RemLife { get; set; }

    public decimal? SalvageVal { get; set; }

    public string? RecvAsst { get; set; }

    public DateTime? RetirDate { get; set; }

    public string? SpDprKey2 { get; set; }

    public decimal? SpDpr2 { get; set; }

    public string? SpDprKey3 { get; set; }

    public string? TransType { get; set; }

    public int? UsefulLife { get; set; }

    public decimal? Appr { get; set; }

    public decimal? WriteUp { get; set; }

    public int? DeltaDays { get; set; }

    public string? NewAstCls { get; set; }

    public decimal? HistOrdDpr { get; set; }

    public decimal? SpDpr3 { get; set; }

    public decimal? TransAmnt { get; set; }

    public string? Remark { get; set; }

    public string? ReTranType { get; set; }

    public int? NewTtlUnit { get; set; }
}
