using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDLogin;

public partial class CvtLaboresExterna
{
    public int IdLabores { get; set; }

    public string Nombre { get; set; } = null!;

    public decimal Tarifa { get; set; }

    public int? IdArea { get; set; }
}
