using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDLogin;

public partial class CvtRespuestaEncuestum
{
    public int IdRespuestas { get; set; }

    public int IdPregunta { get; set; }

    public int Calificacion { get; set; }

    public DateOnly FechaRegistro { get; set; }

    public string? Comentario { get; set; }
}
