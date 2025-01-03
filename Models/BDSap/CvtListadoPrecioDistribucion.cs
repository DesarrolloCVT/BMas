using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSap;

public partial class CvtListadoPrecioDistribucion
{
    public string ListaPrecios { get; set; } = null!;

    public string GrupoArticulo { get; set; } = null!;

    public string CodProducto { get; set; } = null!;

    public string? Producto { get; set; }

    public int? Precio { get; set; }

    public decimal? CostoPromedio { get; set; }

    public decimal? UltimoPrecioCompra { get; set; }
}
