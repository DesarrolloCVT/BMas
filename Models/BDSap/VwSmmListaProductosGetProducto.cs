using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSap;

public partial class VwSmmListaProductosGetProducto
{
    public string? FechaActualizacion { get; set; }

    public string ItemCode { get; set; } = null!;

    public string? ItemName { get; set; }

    public string? BcdCode { get; set; }

    public string? UomCode { get; set; }

    public int? UomEntry { get; set; }

    public int? CantidadxUm { get; set; }

    public string? Marca { get; set; }

    public string? Categoria { get; set; }

    public string? SubCategoria { get; set; }

    public string? CodProveedor { get; set; }

    public string? Proveedor { get; set; }

    public int? UMultiplo { get; set; }

    public int? UVentaMinima { get; set; }
}
