using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSap;

public partial class Ostum
{
    public string Code { get; set; } = null!;

    public string? Name { get; set; }

    public decimal? Rate { get; set; }

    public string? SalesTax { get; set; }

    public string? UseTax { get; set; }

    public int Type { get; set; }

    public short? UserSign { get; set; }

    public string? PurchTax { get; set; }

    public string? DeferrAcct { get; set; }

    public decimal? NonDdctPrc { get; set; }

    public string? NonDdctAct { get; set; }

    public string? TaxInPrice { get; set; }

    public string? Exempt { get; set; }

    public string? ApexpAct { get; set; }

    public string? ArexpAct { get; set; }

    public decimal? CredBala { get; set; }

    public decimal? CredFg { get; set; }

    public decimal? CredCg { get; set; }

    public string? InGrossRev { get; set; }

    public DateTime? EfctDate { get; set; }

    public decimal? SvcTaxCr { get; set; }

    public decimal? MinAmount { get; set; }

    public decimal? MaxAmount { get; set; }

    public decimal? FlatAmount { get; set; }

    public short? TextCode { get; set; }

    public string? UnencumTax { get; set; }

    public string? TaxOnRi { get; set; }

    public string? DiotrptTyp { get; set; }

    public string? IsSystem { get; set; }

    public decimal? RvsCrgPrc { get; set; }

    public string? InFirstIns { get; set; }

    public string? SaleTaxRcm { get; set; }

    public string? SaleRcmclr { get; set; }

    public string? VatExempt { get; set; }

    public decimal? VatExmPrc { get; set; }

    public decimal? VatExmBase { get; set; }
}
