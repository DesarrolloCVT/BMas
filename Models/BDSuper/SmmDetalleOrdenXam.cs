using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSuper;

public partial class SmmDetalleOrdenXam
{
    public string? CodProducto { get; set; }

    public string? ItemName { get; set; }

    public int? Upc { get; set; }

    public int? Familia { get; set; }

    public int? PrecioVenta { get; set; }

    public decimal? Stock { get; set; }

    public int? Cantidad { get; set; }

    public int? PorcDescuento { get; set; }

    public decimal? Margen { get; set; }

    public int? Contribucion { get; set; }

    public string? ImptoTipo { get; set; }

    public decimal? ImptoProcentaje { get; set; }

    public decimal? TotalImpto { get; set; }

    public int? TotalLinea { get; set; }

    public int? TotalContrib { get; set; }

    public int? IdOrdenVentas { get; set; }

    public int IdDetalleOrden { get; set; }

    public int? PrecioPromedio { get; set; }
}
