using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDLogin;

public partial class VwPrcComisionVendedor
{
    public decimal? PrcComi { get; set; }

    public string? TipoComision { get; set; }

    public string ItemCode { get; set; } = null!;
}
