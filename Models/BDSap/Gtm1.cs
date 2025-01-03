using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSap;

public partial class Gtm1
{
    public int AbsEntry { get; set; }

    public int LineNum { get; set; }

    public string? ItemCode { get; set; }

    public string? ItemName { get; set; }

    public string? ItemUoM { get; set; }

    public string? ItemSpec { get; set; }

    public string? ItemTaxCat { get; set; }

    public decimal? Quantity { get; set; }

    public decimal? Amount { get; set; }

    public decimal? VatPercent { get; set; }

    public decimal? DiscRate { get; set; }

    public decimal? DiscAmount { get; set; }

    public decimal? VatAmount { get; set; }

    public decimal? DiscVatAmt { get; set; }

    public decimal? UnitPrice { get; set; }

    public string? UpirceType { get; set; }

    public string? TaxCatCode { get; set; }
}
