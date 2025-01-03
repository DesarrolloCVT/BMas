using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSap;

public partial class VwListaMaterialesCajasTipo
{
    public string? Name { get; set; }

    public string CodProductoPadre { get; set; } = null!;

    public string? CodProducto { get; set; }

    public decimal? Cantidad { get; set; }

    public decimal? Precio { get; set; }
}
