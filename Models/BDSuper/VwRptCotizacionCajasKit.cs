using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSuper;

public partial class VwRptCotizacionCajasKit
{
    public int CotizacionId { get; set; }

    public DateTime? FechaCotizacion { get; set; }

    public string? NombreCliente { get; set; }

    public string? ItemName { get; set; }

    public string? CodProducto { get; set; }

    public int? Cantidad { get; set; }

    public int? PrecioTotal { get; set; }

    public int? CantidadProducir { get; set; }

    public string? NomCaja { get; set; }
}
