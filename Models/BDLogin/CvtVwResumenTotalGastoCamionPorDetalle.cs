using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDLogin;

public partial class CvtVwResumenTotalGastoCamionPorDetalle
{
    public string Patente { get; set; } = null!;

    public string Propietario { get; set; } = null!;

    public string Categoria { get; set; } = null!;

    public string? DetalleGasto { get; set; }

    public int? Monto { get; set; }

    public int? Año { get; set; }
}
