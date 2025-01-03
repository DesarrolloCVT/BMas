using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSap;

public partial class Osct
{
    public short CallTypeId { get; set; }

    public string Name { get; set; } = null!;

    public string? Descriptio { get; set; }

    public string? Active { get; set; }
}
