using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSap;

public partial class Rdr4
{
    public int DocEntry { get; set; }

    public int? LineNum { get; set; }

    public int? GroupNum { get; set; }

    public int? ExpnsCode { get; set; }

    public int? RelateType { get; set; }

    public string? StcCode { get; set; }

    public string? StaCode { get; set; }

    public int? StaType { get; set; }

    public decimal? TaxRate { get; set; }

    public string? TaxAcct { get; set; }

    public decimal? TaxSum { get; set; }

    public decimal? TaxSumFrgn { get; set; }

    public decimal? TaxSumSys { get; set; }

    public decimal? BaseSum { get; set; }

    public decimal? BaseSumFrg { get; set; }

    public decimal? BaseSumSys { get; set; }

    public string? ObjectType { get; set; }

    public int? LogInstanc { get; set; }

    public string? TaxStatus { get; set; }

    public decimal? VatApplied { get; set; }

    public decimal? VatAppldFc { get; set; }

    public decimal? VatAppldSc { get; set; }

    public int LineSeq { get; set; }

    public string? DeferrAcct { get; set; }

    public int? BaseType { get; set; }

    public int? BaseAbs { get; set; }

    public int? BaseSeq { get; set; }

    public decimal? DeductTax { get; set; }

    public decimal? DdctTaxFrg { get; set; }

    public decimal? DdctTaxSys { get; set; }

    public decimal? BaseAppld { get; set; }

    public decimal? BaseApldFc { get; set; }

    public decimal? BaseApldSc { get; set; }

    public decimal? NonDdctPrc { get; set; }

    public string? NonDdctAct { get; set; }

    public string? TaxInPrice { get; set; }

    public string? Exempt { get; set; }

    public string? TaxExpAct { get; set; }

    public decimal? OnHoldTax { get; set; }

    public decimal? OnHoldTaxF { get; set; }

    public decimal? OnHoldTaxS { get; set; }

    public string? InGrossRev { get; set; }

    public decimal? TaxSumOrg { get; set; }

    public decimal? TaxSumOrgF { get; set; }

    public decimal? TaxSumOrgS { get; set; }

    public decimal? OpenTax { get; set; }

    public decimal? OpenTaxFc { get; set; }

    public decimal? OpenTaxSc { get; set; }

    public string? Unencumbrd { get; set; }

    public string? TaxOnRi { get; set; }

    public decimal? RvsChrgPrc { get; set; }

    public decimal? RvsChrgTax { get; set; }

    public decimal? RvsChrgSc { get; set; }

    public decimal? RvsChrgFc { get; set; }

    public string? InFirstIns { get; set; }

    public decimal? ExtTaxRate { get; set; }

    public decimal? ExtTaxSum { get; set; }

    public string? TaxAmtSrc { get; set; }

    public decimal? ExtTaxSumF { get; set; }

    public decimal? ExtTaxSumS { get; set; }

    public string? Cestrel { get; set; }
}
