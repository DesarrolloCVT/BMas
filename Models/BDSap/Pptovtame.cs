using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSap;

public partial class Pptovtame
{
    public string Code { get; set; } = null!;

    public string Name { get; set; } = null!;

    public int? UMes { get; set; }

    public decimal? UMonto { get; set; }
}
