using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDLogin;

public partial class VwVencimientosProyectadosCvt
{
    public string? Bodega { get; set; }

    public string? CodProducto { get; set; }

    public string? Producto { get; set; }

    public string Grupo { get; set; } = null!;

    public DateOnly? Fvencimiento { get; set; }

    public string Estado { get; set; } = null!;

    public int? DiasVencimiento { get; set; }

    public decimal? PrecioUnit { get; set; }

    public int? Cantidad { get; set; }

    public int? Costo { get; set; }

    public int Enumerador { get; set; }
}
