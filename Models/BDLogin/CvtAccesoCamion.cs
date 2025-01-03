using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDLogin;

public partial class CvtAccesoCamion
{
    public int IdCamion { get; set; }

    public string? Patente { get; set; }

    public int? RevisionTecnica { get; set; }

    public int? PermisoCirculacion { get; set; }

    public string? Observaciones { get; set; }
}
