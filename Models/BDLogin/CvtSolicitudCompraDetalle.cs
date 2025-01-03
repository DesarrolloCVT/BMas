using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDLogin;

public partial class CvtSolicitudCompraDetalle
{
    public int SolicitudCompraDetalleId { get; set; }

    public int SolicitudCompraId { get; set; }

    public string? CodProducto { get; set; }

    public string Descripcion { get; set; } = null!;

    public string? Proveedor { get; set; }

    public string? Division { get; set; }

    public string? UnidadAdministrativa { get; set; }

    public string? CentroCostro { get; set; }

    public string? ItemGasto { get; set; }

    public decimal? PrecioInfo { get; set; }

    public decimal? Descuento { get; set; }

    public string? Almacen { get; set; }
}
