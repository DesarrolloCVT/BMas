using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDLogin;

public partial class CvtNotaMargen
{
    public int Cnota { get; set; }

    public int? Desde { get; set; }

    public int? Hasta { get; set; }

    public decimal? Nota { get; set; }
}
