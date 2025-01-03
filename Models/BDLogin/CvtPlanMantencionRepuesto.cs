using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDLogin;

public partial class CvtPlanMantencionRepuesto
{
    public int IdRepuestoPlanMantencion { get; set; }

    public string? Descripcion { get; set; }

    public int? IdPlanMantencion { get; set; }
}
