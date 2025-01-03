using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSap;

public partial class Trt1
{
    public string TrtCode { get; set; } = null!;

    public int Sequence { get; set; }

    public string? AcctCode { get; set; }

    public string? LineDescr { get; set; }

    public decimal? Debit { get; set; }

    public decimal? Credit { get; set; }

    public string? VatGroup { get; set; }

    public short? UserSign { get; set; }

    public string? VatLine { get; set; }

    public string? CtrlAcct { get; set; }

    public string? OcrCode { get; set; }

    public short? TaxType { get; set; }

    public string? TaxPostAcc { get; set; }

    public string? StaCode { get; set; }

    public int? StaType { get; set; }

    public string? TaxCode { get; set; }

    public string? OcrCode1 { get; set; }

    public string? OcrCode2 { get; set; }

    public string? OcrCode3 { get; set; }

    public string? OcrCode4 { get; set; }

    public string? OcrCode5 { get; set; }

    public string? WtLiable { get; set; }

    public string? WtaxLine { get; set; }

    public decimal? GrossValue { get; set; }

    public string? Project { get; set; }

    public string? CemCode { get; set; }
}
