using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSap;

public partial class VwMmetroEtiquetaPrecio
{
    public string CodProducto { get; set; } = null!;

    public string? Producto { get; set; }

    public string? Medida { get; set; }

    public int? Precio { get; set; }

    public int? Base { get; set; }
}
