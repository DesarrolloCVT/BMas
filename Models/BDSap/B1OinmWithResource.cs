using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSap;

public partial class B1OinmWithResource
{
    public int TransNum { get; set; }

    public int? TransType { get; set; }

    public int? CreatedBy { get; set; }

    public string BaseRef { get; set; } = null!;

    public int? DocLineNum { get; set; }

    public DateTime? DocDate { get; set; }

    public DateTime? DocDueDate { get; set; }

    public string CardCode { get; set; } = null!;

    public string CardName { get; set; } = null!;

    public string? Ref1 { get; set; }

    public string Ref2 { get; set; } = null!;

    public string Comments { get; set; } = null!;

    public string JrnlMemo { get; set; } = null!;

    public short? DocTime { get; set; }

    public string ItemCode { get; set; } = null!;

    public string? Dscription { get; set; }

    public decimal? InQty { get; set; }

    public decimal? OutQty { get; set; }

    public decimal? Price { get; set; }

    public string Currency { get; set; } = null!;

    public int Rate { get; set; }

    public string VendorNum { get; set; } = null!;

    public string SerialNum { get; set; } = null!;

    public string? Warehouse { get; set; }

    public string TreeType { get; set; } = null!;

    public int SlpCode { get; set; }

    public DateTime? TaxDate { get; set; }

    public string DataSource { get; set; } = null!;

    public string PrjCode { get; set; } = null!;

    public int UserSign { get; set; }

    public string BlockNum { get; set; } = null!;

    public string ImportLog { get; set; } = null!;

    public string UseDocPric { get; set; } = null!;

    public int Location { get; set; }

    public int CalcPrice { get; set; }

    public int OpenQty { get; set; }

    public int Instance { get; set; }

    public int LastInst { get; set; }

    public int RevalTotal { get; set; }

    public string BaseCurr { get; set; } = null!;

    public int? ApplObj { get; set; }

    public int? AppObjAbs { get; set; }

    public string AppObjType { get; set; } = null!;

    public string StockAct { get; set; } = null!;

    public string TrnsfrAct { get; set; } = null!;

    public string PriceDifAc { get; set; } = null!;

    public string VarianceAc { get; set; } = null!;

    public string ReturnAct { get; set; } = null!;

    public string ExcRateAct { get; set; } = null!;

    public string ClearAct { get; set; } = null!;

    public string CostAct { get; set; } = null!;

    public string WipAct { get; set; } = null!;

    public int Balance { get; set; }

    public DateTime? CreateDate { get; set; }

    public int? BaseLine { get; set; }

    public int TransValue { get; set; }

    public int PriceDiff { get; set; }

    public int TransSeq { get; set; }

    public string InvntAct { get; set; } = null!;

    public string RemMethod { get; set; } = null!;

    public int OpenValue { get; set; }

    public int SubLineNum { get; set; }

    public int? AppObjLine { get; set; }

    public int Expenses { get; set; }

    public int OpenExp { get; set; }

    public int Allocation { get; set; }

    public int OpenAlloc { get; set; }

    public int ExpAlloc { get; set; }

    public int OexpAlloc { get; set; }

    public int OpenPdiff { get; set; }

    public int ExchDiff { get; set; }

    public int OpenEdiff { get; set; }

    public int NegInvAdjs { get; set; }

    public int OpenNegInv { get; set; }

    public string NegStckAct { get; set; } = null!;

    public int BtransVal { get; set; }

    public int VarVal { get; set; }

    public int BexpVal { get; set; }

    public int CogsVal { get; set; }

    public int BnegAval { get; set; }

    public string IoffIncAcc { get; set; } = null!;

    public int IoffIncVal { get; set; }

    public string DoffDecAcc { get; set; } = null!;

    public int DoffDecVal { get; set; }

    public string DecAcc { get; set; } = null!;

    public int DecVal { get; set; }

    public int WipVal { get; set; }

    public string WipVarAcc { get; set; } = null!;

    public int WipVarVal { get; set; }

    public string IncAct { get; set; } = null!;

    public int IncVal { get; set; }

    public string ExpCacc { get; set; } = null!;

    public string CostMethod { get; set; } = null!;

    public string OcrCode { get; set; } = null!;

    public int BaseQty { get; set; }

    public int PrevTrans { get; set; }

    public int HtransSeq { get; set; }

    public string OcrCode2 { get; set; } = null!;

    public string OcrCode3 { get; set; } = null!;

    public string OcrCode4 { get; set; } = null!;

    public string OcrCode5 { get; set; } = null!;

    public int? StgSeqNum { get; set; }

    public int? StgEntry { get; set; }

    public string? StgDesc { get; set; }
}
