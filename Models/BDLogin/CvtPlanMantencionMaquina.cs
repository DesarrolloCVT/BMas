using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDLogin;

public partial class CvtPlanMantencionMaquina
{
    public int IdMaquinaPlanMantencion { get; set; }

    public string CodMaquina { get; set; } = null!;

    public string Descripcion { get; set; } = null!;

    public int IdPlanMantencion { get; set; }
}
