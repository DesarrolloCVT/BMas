using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDLogin;

public partial class CvtVwResumenConsumoCombustiblePorMe
{
    public string Propietario { get; set; } = null!;

    public string Patente { get; set; } = null!;

    public decimal? TotalConsumo { get; set; }

    public decimal? TotalLitros { get; set; }

    public int? Mes { get; set; }

    public int? Año { get; set; }
}
