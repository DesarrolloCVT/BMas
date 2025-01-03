using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDLogin;

public partial class CvtPlanMantencionParte
{
    public int IdPartePlanMantencion { get; set; }

    public string CodParte { get; set; } = null!;

    public string Descripcion { get; set; } = null!;

    public int IdPlanMantencion { get; set; }
}
