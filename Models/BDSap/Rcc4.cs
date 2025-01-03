using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSap;

public partial class Rcc4
{
    public int DocNum { get; set; }

    public int LineId { get; set; }

    public string? AcctCode { get; set; }

    public decimal? SumApplied { get; set; }

    public decimal? AppliedFc { get; set; }

    public decimal? AppliedSys { get; set; }

    public string? Descrip { get; set; }

    public string? VatGroup { get; set; }

    public decimal? VatPrcnt { get; set; }

    public string? AcctName { get; set; }

    public string? ObjType { get; set; }

    public int? LogInstanc { get; set; }

    public string? OcrCode { get; set; }

    public string? Project { get; set; }

    public decimal? GrossAmnt { get; set; }

    public decimal? GrssAmntFc { get; set; }

    public decimal? GrssAmntSc { get; set; }

    public string? AmntBase { get; set; }

    public decimal? VatAmnt { get; set; }

    public decimal? VatAmntFc { get; set; }

    public decimal? VatAmntSc { get; set; }

    public string? UserChaVat { get; set; }

    public int? TaxTypeId { get; set; }

    public string? OcrCode2 { get; set; }

    public string? OcrCode3 { get; set; }

    public string? OcrCode4 { get; set; }

    public string? OcrCode5 { get; set; }

    public int? Section { get; set; }

    public string? AsseType { get; set; }

    public int? LocCode { get; set; }

    public int? MatType { get; set; }

    public decimal? EquVatPer { get; set; }

    public decimal? EquVatSum { get; set; }

    public decimal? EquVatSumF { get; set; }

    public decimal? EquVatSumS { get; set; }

    public string? EncryptIv { get; set; }
}
