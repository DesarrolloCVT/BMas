using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDLogin;

public partial class CvtPlanificacionMantencion
{
    public int MantencionId { get; set; }

    public int MaquinaId { get; set; }

    public int ParteId { get; set; }

    public int? ComponenteId { get; set; }

    public DateTime Fecha { get; set; }

    public string Periodicidad { get; set; } = null!;

    public int TipoMantencionId { get; set; }

    public int RecursoId { get; set; }

    public DateTime? FechaInicio { get; set; }

    public DateTime? FechaTermino { get; set; }

    public int? Estado { get; set; }

    public bool? Ocacional { get; set; }

    public string? Observacion { get; set; }
}
