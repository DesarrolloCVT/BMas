using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSap;

public partial class Ohp
{
    public int PosId { get; set; }

    public string Name { get; set; } = null!;

    public string? Descriptio { get; set; }

    public string? LocFields { get; set; }
}
