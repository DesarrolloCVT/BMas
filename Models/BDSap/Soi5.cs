using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSap;

public partial class Soi5
{
    public int WizardId { get; set; }

    public int Soinum { get; set; }

    public int DocType { get; set; }

    public int DocEntry { get; set; }

    public int SoilineNum { get; set; }

    public int DocLineNum { get; set; }

    public string? ItemCode { get; set; }

    public string? ItemName { get; set; }

    public string? UnitMsr { get; set; }

    public decimal? Quantity { get; set; }

    public decimal? TotalFrgn { get; set; }

    public decimal? LineTotal { get; set; }

    public string? Currency { get; set; }

    public decimal? Rate { get; set; }

    public decimal? BaseRate { get; set; }

    public string? BasNumAtCr { get; set; }

    public int? BaseDocNum { get; set; }

    public int? BaseEntry { get; set; }

    public DateTime? BasTaxDate { get; set; }

    public decimal? FexcBasSum { get; set; }

    public decimal? AexcBasSum { get; set; }

    public int? ExciseUoM { get; set; }

    public decimal? ExcRateUoM { get; set; }

    public decimal? ExcRateAdV { get; set; }

    public decimal? ExciseSum { get; set; }

    public decimal? VatBaseSum { get; set; }

    public decimal? VatPrcnt { get; set; }

    public decimal? VatSum { get; set; }

    public string? TaxCtgr { get; set; }

    public string? VatGroup { get; set; }
}
