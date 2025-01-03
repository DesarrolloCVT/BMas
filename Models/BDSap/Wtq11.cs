using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSap;

public partial class Wtq11
{
    public int DocEntry { get; set; }

    public int LineNum { get; set; }

    public int LineSeq { get; set; }

    public int? BaseAbs { get; set; }

    public int? BaseType { get; set; }

    public string? VatGroup { get; set; }

    public decimal? VatPrcnt { get; set; }

    public decimal? LineTotal { get; set; }

    public decimal? TotalFrgn { get; set; }

    public decimal? TotalSumSy { get; set; }

    public decimal? VatSum { get; set; }

    public decimal? VatSumFrgn { get; set; }

    public decimal? VatSumSys { get; set; }

    public string? ObjType { get; set; }

    public int? LogInstanc { get; set; }

    public string? IsAcq { get; set; }

    public string? IsAllDrawn { get; set; }

    public string? IsGross { get; set; }

    public decimal? Gross { get; set; }

    public decimal? GrossFc { get; set; }

    public decimal? GrossSc { get; set; }

    public decimal? ApplNet { get; set; }

    public decimal? ApplNetFc { get; set; }

    public decimal? ApplNetSc { get; set; }

    public decimal? ApplVat { get; set; }

    public decimal? ApplVatFc { get; set; }

    public decimal? ApplVatSc { get; set; }

    public decimal? BaseNet { get; set; }

    public decimal? BaseNetFc { get; set; }

    public decimal? BaseNetSc { get; set; }

    public decimal? BaseVat { get; set; }

    public decimal? BaseVatFc { get; set; }

    public decimal? BaseVatSc { get; set; }

    public decimal? BaseGross { get; set; }

    public decimal? BaseGrossF { get; set; }

    public decimal? BaseGrossS { get; set; }

    public string? LineType { get; set; }

    public decimal? DctSum { get; set; }

    public decimal? DctSumFc { get; set; }

    public decimal? DctSumSc { get; set; }

    public decimal? EqSum { get; set; }

    public decimal? EqSumFc { get; set; }

    public decimal? EqSumSc { get; set; }

    public decimal? ApplDct { get; set; }

    public decimal? ApplDctFc { get; set; }

    public decimal? ApplDctSc { get; set; }

    public decimal? ApplEq { get; set; }

    public decimal? ApplEqFc { get; set; }

    public decimal? ApplEqSc { get; set; }

    public decimal? BaseDct { get; set; }

    public decimal? BaseDctFc { get; set; }

    public decimal? BaseDctSc { get; set; }

    public decimal? BaseEq { get; set; }

    public decimal? BaseEqFc { get; set; }

    public decimal? BaseEqSc { get; set; }

    public string? TaxCode { get; set; }

    public decimal? ApplGross { get; set; }

    public decimal? ApplGrossF { get; set; }

    public decimal? ApplGrossS { get; set; }

    public string? TaxAdjust { get; set; }

    public decimal? RvsChrgSum { get; set; }

    public decimal? RvsChrgFc { get; set; }

    public decimal? RvsChrgSc { get; set; }

    public decimal? BasRvsChrg { get; set; }

    public decimal? BasRvsFc { get; set; }

    public decimal? BasRvsSc { get; set; }

    public decimal? ApplRvs { get; set; }

    public decimal? ApplRvsFc { get; set; }

    public decimal? ApplRvsSc { get; set; }

    public string? IsCstmAct { get; set; }
}
