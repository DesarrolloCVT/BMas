using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSap;

public partial class BmasVwLogModificacionesProducto
{
    public string CodProducto { get; set; } = null!;

    public string? Producto { get; set; }

    public DateTime? FechaModificacion { get; set; }

    public string Usuario { get; set; } = null!;

    public decimal? PrecioUmanterior { get; set; }

    public decimal? PrecioUmactual { get; set; }

    public decimal? PrecioUnidadAnterio { get; set; }

    public decimal? PrecioUnidadActual { get; set; }

    public string UsuarioVersionActual { get; set; } = null!;
}
