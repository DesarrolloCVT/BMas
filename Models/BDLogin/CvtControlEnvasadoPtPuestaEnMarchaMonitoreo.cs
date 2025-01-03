using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDLogin;

public partial class CvtControlEnvasadoPtPuestaEnMarchaMonitoreo
{
    public int IdPuestaEnMarchaMonitoreo { get; set; }

    public int? IdControlEnvPt { get; set; }

    public string? Turno { get; set; }

    public TimeOnly? Hora { get; set; }

    public string? GolpesMin { get; set; }

    public string? Observacion { get; set; }

    public int? IdUsuario { get; set; }

    public DateTime? FechaRegistro { get; set; }
}
