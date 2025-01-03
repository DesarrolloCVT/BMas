using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSap;

public partial class Sivl
{
    public int? TransType { get; set; }

    public int? CreatedBy { get; set; }

    public string? BaseRef { get; set; }

    public int? DocLineNum { get; set; }

    public DateTime? DocDate { get; set; }

    public short? CreateTime { get; set; }

    public string? ItemCode { get; set; }

    public decimal? InQty { get; set; }

    public decimal? OutQty { get; set; }

    public decimal? Price { get; set; }

    public string? Currency { get; set; }

    public decimal? Rate { get; set; }

    public string? TrnsfrAct { get; set; }

    public string? PriceDifAc { get; set; }

    public string? VarianceAc { get; set; }

    public string? ReturnAct { get; set; }

    public string? ExcRateAct { get; set; }

    public string? ClearAct { get; set; }

    public string? CostAct { get; set; }

    public string? WipAct { get; set; }

    public decimal? OpenStock { get; set; }

    public DateTime? CreateDate { get; set; }

    public decimal? PriceDiff { get; set; }

    public int TransSeq { get; set; }

    public string? InvntAct { get; set; }

    public int? SubLineNum { get; set; }

    public int? AppObjLine { get; set; }

    public decimal? Expenses { get; set; }

    public decimal? OpenExp { get; set; }

    public decimal? Allocation { get; set; }

    public decimal? OpenAlloc { get; set; }

    public decimal? ExpAlloc { get; set; }

    public decimal? OexpAlloc { get; set; }

    public decimal? OpenPdiff { get; set; }

    public decimal? ExchDiff { get; set; }

    public decimal? OpenEdiff { get; set; }

    public decimal? NegInvAdjs { get; set; }

    public decimal? OpenNegInv { get; set; }

    public string? NegStckAct { get; set; }

    public decimal? BtransVal { get; set; }

    public decimal? VarVal { get; set; }

    public decimal? BexpVal { get; set; }

    public decimal? CogsVal { get; set; }

    public decimal? BnegAval { get; set; }

    public string? IoffIncAcc { get; set; }

    public decimal? IoffIncVal { get; set; }

    public string? DoffDecAcc { get; set; }

    public decimal? DoffDecVal { get; set; }

    public string? DecAcc { get; set; }

    public decimal? DecVal { get; set; }

    public decimal? WipVal { get; set; }

    public string? WipVarAcc { get; set; }

    public decimal? WipVarVal { get; set; }

    public string? IncAct { get; set; }

    public decimal? IncVal { get; set; }

    public string? ExpCacc { get; set; }

    public string? CostMethod { get; set; }

    public int? MessageId { get; set; }

    public int? LocType { get; set; }

    public string? LocCode { get; set; }

    public short? UserSign { get; set; }

    public string? DataSource { get; set; }

    public string? PostStatus { get; set; }

    public decimal? SumStock { get; set; }

    public decimal? OpenCogs { get; set; }

    public decimal? OpenQty { get; set; }

    public int? TreeId { get; set; }

    public int? ParentId { get; set; }

    public string? PaoffAcc { get; set; }

    public decimal? PaoffVal { get; set; }

    public decimal? OpenPaoff { get; set; }

    public string? Paacc { get; set; }

    public decimal? Paval { get; set; }

    public decimal? OpenPa { get; set; }

    public string? LinkArc { get; set; }

    public string? VersionNum { get; set; }

    public int? BsubLineNo { get; set; }

    public string? WipDebCred { get; set; }
}
