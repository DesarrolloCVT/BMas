using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSap;

public partial class SmmVwValidaProductosSmm
{
    public string BcdCode { get; set; } = null!;

    public string ItemCode { get; set; } = null!;

    public string? ItemName { get; set; }

    public int? Price { get; set; }

    public string Um { get; set; } = null!;

    public decimal? CantxUm { get; set; }

    public string GrupoArticulo { get; set; } = null!;

    public string Estado { get; set; } = null!;

    public string? DescFlequera { get; set; }

    public decimal? StockUnidadesSala { get; set; }
}
