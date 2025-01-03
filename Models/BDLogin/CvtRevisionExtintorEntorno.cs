using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDLogin;

public partial class CvtRevisionExtintorEntorno
{
    public int? IdRevisionExtintor { get; set; }

    public int IdRevisionEntorno { get; set; }

    public string? PreguntaEntorno { get; set; }

    public string? RespuestaEntorno { get; set; }

    public string? ObservacionEntorno { get; set; }
}
