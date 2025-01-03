using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDLogin;

public partial class CvtPlanMantencionEncabezado
{
    public int IdPlanMantencion { get; set; }

    public string Asunto { get; set; } = null!;

    public DateTime FechaInicio { get; set; }

    public DateTime FechaTermino { get; set; }

    public DateTime FechaLimite { get; set; }

    public int CantHoras { get; set; }

    public string Responsable { get; set; } = null!;

    public DateTime FechaRegistro { get; set; }

    public string Usuario { get; set; } = null!;

    public string Estado { get; set; } = null!;

    public string? Alarma { get; set; }

    public string? Observacion { get; set; }
}
