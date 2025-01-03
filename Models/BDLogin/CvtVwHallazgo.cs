using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDLogin;

public partial class CvtVwHallazgo
{
    public DateOnly FechaHallazgo { get; set; }

    public int? Mes { get; set; }

    public int? Año { get; set; }

    public int? Semana { get; set; }

    public string Turno { get; set; } = null!;

    public string? Linea { get; set; }

    public string Area { get; set; } = null!;

    public string CodProducto { get; set; } = null!;

    public string? Producto { get; set; }

    public string Familia { get; set; } = null!;

    public string Categoria { get; set; } = null!;

    public string? TipoHallazgo { get; set; }

    public string CodProveedor { get; set; } = null!;

    public string? Proveedor { get; set; }

    public string? ProveedorMixto { get; set; }

    public int? CantHallazgos { get; set; }

    public int Of { get; set; }

    public decimal? PesoProd { get; set; }

    public int? Producido { get; set; }

    public decimal? Ton { get; set; }

    public decimal? Indicador { get; set; }

    public string? Lotes { get; set; }
}
