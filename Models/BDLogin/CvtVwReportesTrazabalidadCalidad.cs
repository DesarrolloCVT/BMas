using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDLogin;

public partial class CvtVwReportesTrazabalidadCalidad
{
    public string Informe { get; set; } = null!;

    public string Reporte { get; set; } = null!;

    public string? LotePt { get; set; }

    public string LoteMp { get; set; } = null!;

    public int Id { get; set; }
}
