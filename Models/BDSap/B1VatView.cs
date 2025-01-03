using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSap;

public partial class B1VatView
{
    public int AbsEntry { get; set; }

    public string SrcObjType { get; set; } = null!;

    public int SrcObjAbs { get; set; }

    public int OrdinLnum { get; set; }

    public int LineSeq { get; set; }

    public int? SrcArrType { get; set; }

    public int? SrcLineNum { get; set; }

    public int? SrcGrpNum { get; set; }

    public string Code { get; set; } = null!;

    public string? StaCode { get; set; }

    public int? StaType { get; set; }

    public string? IsLiable { get; set; }

    public string? TaxType { get; set; }

    public string? IsAcq { get; set; }

    public string? Isdeferred { get; set; }

    public decimal? VatPercent { get; set; }

    public decimal? NdPercent { get; set; }

    public decimal? EqPercent { get; set; }

    public string? CrditDebit { get; set; }

    public string? BaseObjTyp { get; set; }

    public int? BaseAbs { get; set; }

    public int? BaseArrTyp { get; set; }

    public int? BaseLinNum { get; set; }

    public int? BaseGrpNum { get; set; }

    public decimal? BaseSum { get; set; }

    public decimal? BaseSumSc { get; set; }

    public decimal? BaseSumFc { get; set; }

    public decimal? VatSum { get; set; }

    public decimal? VatSumSc { get; set; }

    public decimal? VatSumFc { get; set; }

    public decimal? DeductSum { get; set; }

    public decimal? DedctSumSc { get; set; }

    public decimal? DedctSumFc { get; set; }

    public decimal? EqSum { get; set; }

    public decimal? EqSumSc { get; set; }

    public decimal? EqSumFc { get; set; }

    public string? Name { get; set; }

    public string? IsEc { get; set; }

    public string? TriangularDeal { get; set; }

    public string? GoddsShip { get; set; }

    public string? Category { get; set; }

    public string? DocType { get; set; }

    public DateTime? DocDate { get; set; }

    public DateTime? TaxDate { get; set; }

    public DateTime? VatDate { get; set; }

    public int? DocNum { get; set; }

    public string? LicTradNum { get; set; }

    public string? NumAtCard { get; set; }

    public int? Series { get; set; }

    public string? DocCur { get; set; }

    public decimal? DocRate { get; set; }

    public int? FinncPriod { get; set; }

    public string? Address { get; set; }

    public string? Canceled { get; set; }

    public string? JrnlMemo { get; set; }

    public string? Wtcode { get; set; }

    public string? CardCode { get; set; }

    public string? CardName { get; set; }

    public string? CardType { get; set; }

    public string? City { get; set; }

    public string? Country { get; set; }

    public string? BplicTradNum { get; set; }

    public string? VatIdUnCmp { get; set; }

    public string? AddId { get; set; }

    public string? Indicator { get; set; }

    public string? InsurOp347 { get; set; }

    public string? ResidenNum { get; set; }

    public string? OperatCode { get; set; }

    public string? PayToCode { get; set; }

    public string? IsIct { get; set; }

    public string? ServSupply { get; set; }

    public string? Address2 { get; set; }

    public int? Cig { get; set; }

    public int? Cup { get; set; }

    public string? ActType { get; set; }

    public string? IsSplitPay { get; set; }

    public int? Bplid { get; set; }

    public DateTime? CreateDate { get; set; }

    public string? IsCstmAct { get; set; }

    public string? CaoutCode { get; set; }

    public decimal? CabasSum { get; set; }

    public decimal? CabasSumSc { get; set; }

    public decimal? CabasSumFc { get; set; }

    public decimal? CavatSum { get; set; }

    public decimal? CavatSumSc { get; set; }

    public decimal? CavatSumFc { get; set; }

    public string? CaoutAcct { get; set; }

    public string? VatSumSrc { get; set; }

    public int? VatType { get; set; }
}
