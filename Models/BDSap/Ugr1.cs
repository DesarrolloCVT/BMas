using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSap;

public partial class Ugr1
{
    public short GroupLink { get; set; }

    public string PermId { get; set; } = null!;

    public string? Permission { get; set; }
}
