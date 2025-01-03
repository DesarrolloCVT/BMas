using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSap;

public partial class Rrr3
{
    public int DocEntry { get; set; }

    public int? ExpnsCode { get; set; }

    public decimal? LineTotal { get; set; }

    public decimal? TotalFrgn { get; set; }

    public decimal? TotalSumSy { get; set; }

    public decimal? PaidToDate { get; set; }

    public decimal? PaidFc { get; set; }

    public decimal? PaidSys { get; set; }

    public string? Comments { get; set; }

    public string? ObjType { get; set; }

    public int? LogInstanc { get; set; }

    public string? DistrbMthd { get; set; }

    public string? TaxStatus { get; set; }

    public string? VatGroup { get; set; }

    public decimal? VatPrcnt { get; set; }

    public decimal? VatSum { get; set; }

    public decimal? VatSumFrgn { get; set; }

    public decimal? VatSumSy { get; set; }

    public decimal? DedVatSum { get; set; }

    public decimal? DedVatSumF { get; set; }

    public decimal? DedVatSumS { get; set; }

    public string? IsAcquistn { get; set; }

    public string? TaxCode { get; set; }

    public string? TaxType { get; set; }

    public string? Wtliable { get; set; }

    public decimal? VatApplied { get; set; }

    public decimal? VatAppldFc { get; set; }

    public decimal? VatAppldSc { get; set; }

    public decimal? EquVatPer { get; set; }

    public decimal? EquVatSum { get; set; }

    public decimal? EquVatSumF { get; set; }

    public decimal? EquVatSumS { get; set; }

    public decimal? LineVat { get; set; }

    public decimal? LineVatF { get; set; }

    public decimal? LineVatS { get; set; }

    public string? BaseMethod { get; set; }

    public string? Stock { get; set; }

    public string? LstPchPrce { get; set; }

    public string? AnalysRpt { get; set; }

    public int? BaseAbsEnt { get; set; }

    public int? BaseType { get; set; }

    public int? BaseRef { get; set; }

    public int? BaseLnNum { get; set; }

    public int LineNum { get; set; }

    public string? Status { get; set; }

    public int? TrgType { get; set; }

    public int? TrgAbsEnt { get; set; }

    public decimal? StDstr { get; set; }

    public decimal? StDstrSc { get; set; }

    public decimal? StDstrFc { get; set; }

    public string? FixCurr { get; set; }

    public decimal? VatDscntPr { get; set; }

    public string? OcrCode { get; set; }

    public string? TaxDistMtd { get; set; }

    public string? OcrCode2 { get; set; }

    public string? OcrCode3 { get; set; }

    public string? OcrCode4 { get; set; }

    public string? OcrCode5 { get; set; }

    public string? Project { get; set; }

    public string? VatGrpSrc { get; set; }

    public decimal? DrawnTotal { get; set; }

    public decimal? DrawnFc { get; set; }

    public decimal? DrawnSc { get; set; }

    public decimal? GrsAmount { get; set; }

    public decimal? GrsFc { get; set; }

    public decimal? GrsSc { get; set; }

    public string? BaseTotal { get; set; }

    public decimal? RetReqLc { get; set; }

    public decimal? RetReqFc { get; set; }

    public decimal? RetReqSc { get; set; }

    public decimal? RrvatLc { get; set; }

    public decimal? RrvatFc { get; set; }

    public decimal? RrvatSc { get; set; }

    public string? EncryptIv { get; set; }

    public decimal? ExtTaxRate { get; set; }

    public decimal? ExtTaxSum { get; set; }

    public string? TaxAmtSrc { get; set; }

    public decimal? ExtTaxSumF { get; set; }

    public decimal? ExtTaxSumS { get; set; }

    public string? Cusplit { get; set; }
}
