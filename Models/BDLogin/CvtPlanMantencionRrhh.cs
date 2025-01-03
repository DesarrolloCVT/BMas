using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDLogin;

public partial class CvtPlanMantencionRrhh
{
    public int IdRhhplanMantencion { get; set; }

    public string? Run { get; set; }

    public string? Nombre { get; set; }

    public string? Apellido { get; set; }

    public int? IdPlanMantencion { get; set; }
}
