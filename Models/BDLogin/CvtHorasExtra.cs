using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDLogin;

public partial class CvtHorasExtra
{
    public int ExcesoHeId { get; set; }

    public string EmpleadoId { get; set; } = null!;

    public DateTime Fecha { get; set; }

    public TimeOnly Horas { get; set; }

    public short He100 { get; set; }
}
