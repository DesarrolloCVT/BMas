using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSuper;

public partial class SmmComisionProducto
{
    public string CodProducto { get; set; } = null!;

    public string? NombreProducto { get; set; }

    public string? CodSubCategoria { get; set; }

    public decimal? PrcComision { get; set; }

    public string? TipoComision { get; set; }

    public int? CodCategoria { get; set; }

    public string? UMarcaProducto { get; set; }
}
