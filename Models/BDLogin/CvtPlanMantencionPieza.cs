using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDLogin;

public partial class CvtPlanMantencionPieza
{
    public int IdPiezaPlanMantencion { get; set; }

    public string CodPieza { get; set; } = null!;

    public string Descripcion { get; set; } = null!;

    public int IdPlanMantencion { get; set; }
}
