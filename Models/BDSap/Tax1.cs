using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSap;

public partial class Tax1
{
    public int AbsEntry { get; set; }

    public int LineSeq { get; set; }

    public int? SrcArrType { get; set; }

    public int? SrcLineNum { get; set; }

    public int? SrcGrpNum { get; set; }

    public string? TaxCode { get; set; }

    public string? StaCode { get; set; }

    public int? StaType { get; set; }

    public int? StaIndex { get; set; }

    public string? IsLiable { get; set; }

    public string? TaxType { get; set; }

    public string? IsAcq { get; set; }

    public string? Isdeferred { get; set; }

    public DateTime? ValueDate { get; set; }

    public decimal? VatPercent { get; set; }

    public decimal? NdPercent { get; set; }

    public decimal? EqPercent { get; set; }

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

    public string? TaxAcct { get; set; }

    public string? DefAcct { get; set; }

    public string? NdAcct { get; set; }

    public string? AcqAcct { get; set; }

    public string? ExpAcct { get; set; }

    public string? CrditDebit { get; set; }

    public string? PostingTyp { get; set; }

    public decimal? BasePaid { get; set; }

    public decimal? BasePaidSc { get; set; }

    public decimal? BasePaidFc { get; set; }

    public decimal? VatPaid { get; set; }

    public decimal? VatPaidSc { get; set; }

    public decimal? VatPaidFc { get; set; }

    public decimal? DeductPaid { get; set; }

    public decimal? DdctPaidSc { get; set; }

    public decimal? DdctPaidFc { get; set; }

    public decimal? EqPaid { get; set; }

    public decimal? EqPaidSc { get; set; }

    public decimal? EqPaidFc { get; set; }

    public string? TransAcct { get; set; }

    public int? LnDataNum { get; set; }

    public string? InPrice { get; set; }

    public string? Exempt { get; set; }

    public string? InGrossRev { get; set; }

    public string? PostStatus { get; set; }

    public string? IsItmLevel { get; set; }

    public decimal? MinTamt { get; set; }

    public decimal? MinTamtSc { get; set; }

    public decimal? MinTamtFc { get; set; }

    public decimal? MaxTamt { get; set; }

    public decimal? MaxTamtSc { get; set; }

    public decimal? MaxTamtFc { get; set; }

    public decimal? FlatTamt { get; set; }

    public decimal? FlatTamtSc { get; set; }

    public decimal? FlatTamtFc { get; set; }

    public string? EqTaxAcct { get; set; }

    public string? Reposted { get; set; }

    public string? Unencumbrd { get; set; }

    public string? IsSplitPay { get; set; }

    public string? SplitPayAc { get; set; }

    public string? TaxOnRi { get; set; }

    public decimal? RvsChrgPrc { get; set; }

    public decimal? RvsChrgSum { get; set; }

    public decimal? RvsChrgSc { get; set; }

    public decimal? RvsChrgFc { get; set; }

    public string? GstPayAct { get; set; }

    public decimal? RvsPaid { get; set; }

    public decimal? RvsPaidSc { get; set; }

    public decimal? RvsPaidFc { get; set; }

    public string? InFirstIns { get; set; }

    public string? GstRecvAct { get; set; }

    public string? IsCstmAct { get; set; }

    public string? CaoutCode { get; set; }

    public decimal? CabasSum { get; set; }

    public decimal? CabasSumSc { get; set; }

    public decimal? CabasSumFc { get; set; }

    public decimal? CavatSum { get; set; }

    public decimal? CavatSumSc { get; set; }

    public decimal? CavatSumFc { get; set; }

    public string? CaoutAcct { get; set; }

    public decimal? ExtVatPcnt { get; set; }

    public decimal? ExtVatSum { get; set; }

    public string? VatSumSrc { get; set; }

    public decimal? ExtVatSumF { get; set; }

    public decimal? ExtVatSumS { get; set; }

    public string? AcqRevTax { get; set; }

    public decimal? VatExmPrc { get; set; }

    public decimal? VatExmBase { get; set; }

    public string? RevCharge { get; set; }
}
