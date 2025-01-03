using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDLogin;

public partial class CvtAreaTrabajo
{
    public int IdArea { get; set; }

    public string Nombre { get; set; } = null!;

    public int? TcolacionDia { get; set; }

    public int? TcolacionNoche { get; set; }
}
