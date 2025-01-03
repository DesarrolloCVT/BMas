using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSap;

public partial class Osc
{
    public short StatusId { get; set; }

    public string? Name { get; set; }

    public string? Descriptio { get; set; }

    public string? Locked { get; set; }

    public string? Active { get; set; }
}
