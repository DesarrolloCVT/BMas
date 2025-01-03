using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSap;

public partial class Sinm
{
    public int? TransNum { get; set; }

    public int? TransType { get; set; }

    public int? CreatedBy { get; set; }

    public string? BaseRef { get; set; }

    public int? DocLineNum { get; set; }

    public DateTime? DocDate { get; set; }

    public DateTime? DocDueDate { get; set; }

    public string? CardCode { get; set; }

    public string? CardName { get; set; }

    public string? Ref1 { get; set; }

    public string? Ref2 { get; set; }

    public string? Comments { get; set; }

    public string? JrnlMemo { get; set; }

    public short? DocTime { get; set; }

    public string? ItemCode { get; set; }

    public string? Dscription { get; set; }

    public decimal? InQty { get; set; }

    public decimal? OutQty { get; set; }

    public decimal? Price { get; set; }

    public string? Currency { get; set; }

    public decimal? Rate { get; set; }

    public string? VendorNum { get; set; }

    public string? SerialNum { get; set; }

    public string? Warehouse { get; set; }

    public string? TreeType { get; set; }

    public int? SlpCode { get; set; }

    public DateTime? TaxDate { get; set; }

    public string? DataSource { get; set; }

    public string? PrjCode { get; set; }

    public short? UserSign { get; set; }

    public string? BlockNum { get; set; }

    public string? ImportLog { get; set; }

    public string? UseDocPric { get; set; }

    public int? Location { get; set; }

    public decimal? CalcPrice { get; set; }

    public decimal? OpenQty { get; set; }

    public int? Instance { get; set; }

    public int LastInst { get; set; }

    public decimal? RevalTotal { get; set; }

    public string BaseCurr { get; set; } = null!;

    public int? ApplObj { get; set; }

    public int? AppObjAbs { get; set; }

    public string? AppObjType { get; set; }

    public string StockAct { get; set; } = null!;

    public string? TrnsfrAct { get; set; }

    public string? PriceDifAc { get; set; }

    public string? VarianceAc { get; set; }

    public string? ReturnAct { get; set; }

    public string? ExcRateAct { get; set; }

    public string? ClearAct { get; set; }

    public string? CostAct { get; set; }

    public string? WipAct { get; set; }

    public decimal? Balance { get; set; }

    public DateTime? CreateDate { get; set; }

    public int? BaseLine { get; set; }

    public decimal? TransValue { get; set; }

    public decimal? PriceDiff { get; set; }

    public int TransSeq { get; set; }

    public string? InvntAct { get; set; }

    public string? RemMethod { get; set; }

    public decimal? OpenValue { get; set; }

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

    public int BtransVal { get; set; }

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

    public string? OcrCode { get; set; }

    public int BaseQty { get; set; }

    public int PrevTrans { get; set; }

    public int HtransSeq { get; set; }

    public string? OcrCode2 { get; set; }

    public string? OcrCode3 { get; set; }

    public string? OcrCode4 { get; set; }

    public string? OcrCode5 { get; set; }

    public int? StgSeqNum { get; set; }

    public int? StgEntry { get; set; }

    public string? StgDesc { get; set; }
}
