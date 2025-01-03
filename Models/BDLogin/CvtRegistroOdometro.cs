using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDLogin;

public partial class CvtRegistroOdometro
{
    public int IdRegistroOdometro { get; set; }

    public DateTime FechaRegistro { get; set; }

    public int LecturaOdometro { get; set; }

    public string Patente { get; set; } = null!;

    public int IdUsuario { get; set; }
}
