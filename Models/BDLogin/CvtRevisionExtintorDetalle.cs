using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDLogin;

public partial class CvtRevisionExtintorDetalle
{
    public int? IdRevisionExtintor { get; set; }

    public int IdDetExtintor { get; set; }

    public string? Pregunta { get; set; }

    public string? Respuesta { get; set; }

    public string? Observacion { get; set; }
}
