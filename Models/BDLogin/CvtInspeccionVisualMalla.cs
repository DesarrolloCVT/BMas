using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDLogin;

public partial class CvtInspeccionVisualMalla
{
    public int IdInspeccionMalla { get; set; }

    public DateTime FechaRegistro { get; set; }

    public TimeOnly Hora { get; set; }

    public int MallaSala { get; set; }

    public string Medidas { get; set; } = null!;

    public int IdUsuario { get; set; }

    public short Estadomalla { get; set; }

    public DateTime? FechaIngresoRegistro { get; set; }

    public int? Operador { get; set; }
}
