using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSuper;

public partial class VwPackCajasSmm
{
    public string CodPadre { get; set; } = null!;

    public string? CodProducto { get; set; }

    public decimal? Cantidad { get; set; }

    public decimal? Costo { get; set; }
}
