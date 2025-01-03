using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDLogin;

public partial class CvtVwEncuestasResumenPregunta
{
    public int IdArea { get; set; }

    public string Area { get; set; } = null!;

    public string Aspecto { get; set; } = null!;

    public int IdPregunta { get; set; }

    public string Pregunta { get; set; } = null!;

    public int? SumCalificaciones { get; set; }

    public int? Promedio { get; set; }

    public int? CantRespuestas { get; set; }

    public int? Mes { get; set; }

    public int? Año { get; set; }
}
