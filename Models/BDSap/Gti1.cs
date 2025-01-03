using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSap;

public partial class Gti1
{
    public int AbsEntry { get; set; }

    public int LineNum { get; set; }

    public string? DisctLine { get; set; }

    public string? ItemName { get; set; }

    public string? ItemSpec { get; set; }

    public string? Uom { get; set; }

    public decimal? Quantity { get; set; }

    public decimal? NetAmount { get; set; }

    public decimal? VatPercent { get; set; }

    public decimal? VatAmount { get; set; }

    public decimal? UnitPrice { get; set; }

    public string? UnitPricTp { get; set; }

    public string? ItemTaxCat { get; set; }
}
