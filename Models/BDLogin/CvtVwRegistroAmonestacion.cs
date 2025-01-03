using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDLogin;

public partial class CvtVwRegistroAmonestacion
{
    public DateTime FechaAmonestacion { get; set; }

    public int IdAmonestacion { get; set; }

    public string AreaTrabajo { get; set; } = null!;

    public string Empresa { get; set; } = null!;

    public string Incumplimiento { get; set; } = null!;

    public string? AccionCorrectiva { get; set; }

    public string Amonestador { get; set; } = null!;

    public string? Cargo { get; set; }

    public DateTime PlazoEvaluacion { get; set; }

    public string? Persona { get; set; }

    public string? Verificacion { get; set; }

    public string? Seguimiento { get; set; }

    public int? TipoIncidencia { get; set; }
}
