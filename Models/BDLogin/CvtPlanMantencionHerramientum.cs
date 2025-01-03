using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDLogin;

public partial class CvtPlanMantencionHerramientum
{
    public int IdHerramientaPlanMantencion { get; set; }

    public string? Descripcion { get; set; }

    public int? IdPlanMantencion { get; set; }
}
