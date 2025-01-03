using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDLogin;

public partial class CvtComisionVendedor
{
    public string ItemCode { get; set; } = null!;

    public string? TipoComision { get; set; }

    public decimal? Comision { get; set; }
}
