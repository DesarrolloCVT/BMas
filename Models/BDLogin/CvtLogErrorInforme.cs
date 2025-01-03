using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDLogin;

public partial class CvtLogErrorInforme
{
    public int IdError { get; set; }

    public string? TipoInforme { get; set; }

    public string? DescripcionErr { get; set; }

    public DateTime? FechaError { get; set; }
}
