using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDLogin;

public partial class CvtEmpleadoSueldoBase
{
    public string EmpleadoId { get; set; } = null!;

    public int SueldoBase { get; set; }
}
