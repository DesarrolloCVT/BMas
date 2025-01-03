using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSap;

public partial class Ohst
{
    public int StatusId { get; set; }

    public string Name { get; set; } = null!;

    public string? Descriptio { get; set; }
}
