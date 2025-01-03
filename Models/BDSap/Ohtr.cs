using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSap;

public partial class Ohtr
{
    public int ReasonId { get; set; }

    public string Name { get; set; } = null!;

    public string? Descriptio { get; set; }
}
