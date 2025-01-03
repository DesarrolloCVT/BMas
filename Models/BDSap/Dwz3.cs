using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSap;

public partial class Dwz3
{
    public int WizardId { get; set; }

    public string CardCode { get; set; } = null!;

    public int LetterNum { get; set; }

    public string? AddChecked { get; set; }

    public int? DocAbs { get; set; }

    public decimal? IntrAmt { get; set; }

    public decimal? IntrAmtFc { get; set; }

    public decimal? IntrAmtSc { get; set; }

    public decimal? FeeAmt { get; set; }

    public decimal? FeeAmtFc { get; set; }

    public decimal? FeeAmtSc { get; set; }

    public string? InVatGroup { get; set; }

    public string? InTaxCode { get; set; }

    public string? FeVatGroup { get; set; }

    public string? FeTaxCode { get; set; }

    public decimal? VatPrcnt { get; set; }

    public string? Executed { get; set; }

    public string? Message { get; set; }

    public string? DocCur { get; set; }

    public int? DocNum { get; set; }

    public int? Bplid { get; set; }

    public int? LocCode { get; set; }
}
