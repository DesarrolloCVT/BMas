using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSap;

public partial class Usr3
{
    public short UserLink { get; set; }

    public string PermId { get; set; } = null!;

    public string? Permission { get; set; }
}
