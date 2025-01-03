using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDLogin;

public partial class CvtPreguntaEncuestum
{
    public int IdPregunta { get; set; }

    public string Pregunta { get; set; } = null!;

    public int IdArea { get; set; }

    public int? IdAspectoPregunta { get; set; }

    public int TipoPregunta { get; set; }
}
