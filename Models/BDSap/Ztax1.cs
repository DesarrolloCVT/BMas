using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSap;

public partial class Ztax1
{
    public string Code { get; set; } = null!;

    public string Name { get; set; } = null!;

    public string? UName { get; set; }

    public decimal? URate { get; set; }

    public string? ULvFg { get; set; }

    public string? ULcFg { get; set; }

    public string? ULhFg { get; set; }

    public string? ULrFg { get; set; }

    public string? ULname { get; set; }

    public string? UType { get; set; }

    public string? UF3323 { get; set; }

    public string? UCredito { get; set; }
}
