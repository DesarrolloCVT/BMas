using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSap;

public partial class Odwz
{
    public int WizardId { get; set; }

    public string? WizardName { get; set; }

    public DateTime? ToPayDate { get; set; }

    public DateTime? CreateDate { get; set; }

    public string? Status { get; set; }

    public string? DunLevel { get; set; }

    public string? CreditZero { get; set; }

    public string? PayNoBased { get; set; }

    public string? CrdtNbased { get; set; }

    public string? DunTime { get; set; }

    public short? UserSign { get; set; }

    public DateTime? FromDate { get; set; }

    public DateTime? ToDate { get; set; }

    public string? ManualJes { get; set; }

    public string? DspOpnItms { get; set; }

    public string? AllowNegLt { get; set; }

    public string? DunTerm { get; set; }

    public DateTime? FrmDueDate { get; set; }

    public DateTime? ToDueDate { get; set; }

    public DateTime? UpToDate { get; set; }

    public DateTime? InvPostDat { get; set; }

    public DateTime? InvDueDate { get; set; }

    public DateTime? InvDocDate { get; set; }

    public string? Project { get; set; }

    public string? OcrCode { get; set; }

    public string? OcrCode2 { get; set; }

    public string? OcrCode3 { get; set; }

    public string? OcrCode4 { get; set; }

    public string? OcrCode5 { get; set; }

    public string? InVatGroup { get; set; }

    public string? InTaxCode { get; set; }

    public string? FeVatGroup { get; set; }

    public string? FeTaxCode { get; set; }

    public decimal? VatPrcnt { get; set; }

    public string? AutoRmk { get; set; }

    public string? Remarks { get; set; }

    public int? Series { get; set; }

    public int? Bplid { get; set; }

    public int? LocCode { get; set; }

    public string? VersionNum { get; set; }

    public string? OvrDueOnly { get; set; }

    public string? QuickDisp { get; set; }

    public string? OpnoBased { get; set; }

    public string? CnsdVendor { get; set; }
}
