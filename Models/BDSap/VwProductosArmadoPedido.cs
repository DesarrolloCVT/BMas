using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSap;

public partial class VwProductosArmadoPedido
{
    public int Norden { get; set; }

    public string? CodProd { get; set; }

    public string? Dscription { get; set; }

    public string? CodBarra { get; set; }

    public string? UomCode { get; set; }

    public int? Cantidad { get; set; }
}
