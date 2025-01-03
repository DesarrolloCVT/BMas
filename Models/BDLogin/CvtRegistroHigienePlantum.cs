using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDLogin;

public partial class CvtRegistroHigienePlantum
{
    public int IdRegistroHigienePlanta { get; set; }

    public DateOnly FechaRegistro { get; set; }

    public int IdPersonal { get; set; }

    public int IdTipoZonaHigiene { get; set; }

    public int IdZonaHigiene { get; set; }

    public int IdAreaHigiene { get; set; }

    public bool Cumplimiento { get; set; }

    public string? Observaciones { get; set; }
}
