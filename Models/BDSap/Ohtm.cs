using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSap;

public partial class Ohtm
{
    public int TeamId { get; set; }

    public string Name { get; set; } = null!;

    public string? Descriptio { get; set; }

    public int? LogInstanc { get; set; }
}
