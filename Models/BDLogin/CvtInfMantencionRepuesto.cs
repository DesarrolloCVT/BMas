using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDLogin;

public partial class CvtInfMantencionRepuesto
{
    public int IdInfMantencionRepuestos { get; set; }

    public string? Pieza { get; set; }

    public int? Cantidad { get; set; }

    public int? Precio { get; set; }

    public int? IdMantInfEnc { get; set; }
}
