using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSap;

public partial class SmmVwInformeVentasMasStock
{
    public string? CodProveedor { get; set; }

    public string? Proveedor { get; set; }

    public string? SkuProveedor { get; set; }

    public string Grupo { get; set; } = null!;

    public string? CodProducto { get; set; }

    public string? Producto { get; set; }

    public decimal? Upc { get; set; }

    public decimal? StockActual { get; set; }

    public decimal? StockMinimo { get; set; }

    public decimal? UltimoMes { get; set; }

    public decimal? DosMeses { get; set; }

    public decimal? TresMeses { get; set; }

    public decimal? CantidadUltimaCompra { get; set; }

    public DateTime? FechaUltimaCompra { get; set; }

    public decimal? PrecioVenta { get; set; }

    public decimal? UltimoPrecioCompra { get; set; }

    public decimal? CostoPromedio { get; set; }
}
