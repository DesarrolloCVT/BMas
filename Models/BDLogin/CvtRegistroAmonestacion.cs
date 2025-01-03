using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDLogin;

public partial class CvtRegistroAmonestacion
{
    public int IdAmonestacion { get; set; }

    public DateTime FechaAmonestacion { get; set; }

    public string IdPersonal { get; set; } = null!;

    public int IdArea { get; set; }

    public string Deptid { get; set; } = null!;

    public string Incumplimiento { get; set; } = null!;

    public string? AccionCorrectiva { get; set; }

    public int IdAmonestador { get; set; }

    public DateTime PlazoEvaluacion { get; set; }

    public DateTime FechaRegistro { get; set; }

    public string? Verificacion { get; set; }

    public string? Seguimiento { get; set; }

    public int? TipoIncidencia { get; set; }
}
