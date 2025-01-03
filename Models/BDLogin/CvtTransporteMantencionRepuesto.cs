using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDLogin;

public partial class CvtTransporteMantencionRepuesto
{
    public int IdRepuestosTransporte { get; set; }

    public int? IdMantencionTransporte { get; set; }

    public string? Repuesto { get; set; }

    public string ValorRepuesto { get; set; } = null!;
}
