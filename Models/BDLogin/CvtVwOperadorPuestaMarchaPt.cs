using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDLogin;

public partial class CvtVwOperadorPuestaMarchaPt
{
    public int? IdControlEnvPt { get; set; }

    public int IdMonPuestaMarchaMaq { get; set; }

    public string Operador1 { get; set; } = null!;

    public string? Operador2 { get; set; }
}
