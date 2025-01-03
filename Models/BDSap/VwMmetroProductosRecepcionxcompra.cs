using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSap;

public partial class VwMmetroProductosRecepcionxcompra
{
    public string? ItemCode { get; set; }

    public string? Dscription { get; set; }

    public int DocNum { get; set; }

    public decimal? OpenQty { get; set; }

    public int? UomEntry { get; set; }

    public string? UomCode { get; set; }

    public string? CardCode { get; set; }

    public string CodeBars { get; set; } = null!;
}
