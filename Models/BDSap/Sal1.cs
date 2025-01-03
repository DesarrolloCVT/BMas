using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSap;

public partial class Sal1
{
    public int DocEntry { get; set; }

    public int LineNum { get; set; }

    public int? BaseEntry { get; set; }

    public decimal? PackQty { get; set; }

    public string? PurPackMsr { get; set; }

    public string? ArsnalName { get; set; }

    public string? ArsnalCode { get; set; }

    public string? UnitMsr { get; set; }

    public decimal? Quantity { get; set; }

    public decimal? Fraction { get; set; }

    public decimal? Weight1 { get; set; }

    public decimal? LineTotal { get; set; }

    public string? ItemCode { get; set; }
}
