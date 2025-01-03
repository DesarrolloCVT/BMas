using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSap;

public partial class Oei15
{
    public int DocEntry { get; set; }

    public int LineNum { get; set; }

    public string? ObjType { get; set; }

    public int? LogInstanc { get; set; }

    public string? VatGroup { get; set; }

    public string? StaCode { get; set; }

    public int? StaType { get; set; }

    public int? StaIndex { get; set; }

    public decimal? BaseNet { get; set; }

    public decimal? BaseNetFc { get; set; }

    public decimal? BaseNetSc { get; set; }

    public decimal? VatSum { get; set; }

    public decimal? VatSumFc { get; set; }

    public decimal? VatSumSc { get; set; }

    public decimal? DctSum { get; set; }

    public decimal? DctSumFc { get; set; }

    public decimal? DctSumSc { get; set; }

    public decimal? EqSum { get; set; }

    public decimal? EqSumFc { get; set; }

    public decimal? EqSumSc { get; set; }

    public decimal? ApplNet { get; set; }

    public decimal? ApplNetFc { get; set; }

    public decimal? ApplNetSc { get; set; }

    public decimal? ApplVat { get; set; }

    public decimal? ApplVatFc { get; set; }

    public decimal? ApplVatSc { get; set; }

    public decimal? ApplDct { get; set; }

    public decimal? ApplDctFc { get; set; }

    public decimal? ApplDctSc { get; set; }

    public decimal? ApplEq { get; set; }

    public decimal? ApplEqFc { get; set; }

    public decimal? ApplEqSc { get; set; }

    public decimal? PaidNet { get; set; }

    public decimal? PaidNetFc { get; set; }

    public decimal? PaidNetSc { get; set; }

    public decimal? PaidVat { get; set; }

    public decimal? PaidVatFc { get; set; }

    public decimal? PaidVatSc { get; set; }

    public decimal? PaidDct { get; set; }

    public decimal? PaidDctFc { get; set; }

    public decimal? PaidDctSc { get; set; }

    public decimal? PaidEq { get; set; }

    public decimal? PaidEqFc { get; set; }

    public decimal? PaidEqSc { get; set; }

    public decimal? DpApplNet { get; set; }

    public decimal? DpApplNetF { get; set; }

    public decimal? DpApplNetS { get; set; }

    public decimal? DpApplVat { get; set; }

    public decimal? DpApplVatF { get; set; }

    public decimal? DpApplVatS { get; set; }

    public decimal? DpApplDct { get; set; }

    public decimal? DpApplDctF { get; set; }

    public decimal? DpApplDctS { get; set; }

    public decimal? DpApplEq { get; set; }

    public decimal? DpApplEqFc { get; set; }

    public decimal? DpApplEqSc { get; set; }

    public string? TaxCode { get; set; }

    public string? LineType { get; set; }

    public decimal? BaseGrs { get; set; }

    public decimal? BaseGrsFc { get; set; }

    public decimal? BaseGrsSc { get; set; }

    public decimal? ApplGrs { get; set; }

    public decimal? ApplGrsFc { get; set; }

    public decimal? ApplGrsSc { get; set; }

    public decimal? PaidGrs { get; set; }

    public decimal? PaidGrsFc { get; set; }

    public decimal? PaidGrsSc { get; set; }

    public decimal? DpApplGrs { get; set; }

    public decimal? DpApplGrsF { get; set; }

    public decimal? DpApplGrsS { get; set; }

    public decimal? RvsChrgSum { get; set; }

    public decimal? RvsChrgSc { get; set; }

    public decimal? RvsChrgFc { get; set; }

    public decimal? ApplRvs { get; set; }

    public decimal? ApplRvsSc { get; set; }

    public decimal? ApplRvsFc { get; set; }

    public decimal? PaidRvs { get; set; }

    public decimal? PaidRvsSc { get; set; }

    public decimal? PaidRvsFc { get; set; }

    public decimal? DpApplRvs { get; set; }

    public decimal? DpApplRvsS { get; set; }

    public decimal? DpApplRvsF { get; set; }

    public string? IsPrscGood { get; set; }

    public string? IsCstmAct { get; set; }
}
