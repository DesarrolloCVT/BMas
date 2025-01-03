using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSuper;

public partial class VwSmmDatoProductosNotacredito
{
    public int DocEntry { get; set; }

    public string? ItemCode { get; set; }

    public string? Dscription { get; set; }

    public decimal? Quantity { get; set; }

    public decimal? Price { get; set; }

    public decimal? Descuento { get; set; }

    public decimal? Total { get; set; }
}
