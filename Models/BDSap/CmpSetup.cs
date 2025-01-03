using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSap;

public partial class CmpSetup
{
    public string Code { get; set; } = null!;

    public string Name { get; set; } = null!;

    public string? UCmpAddn { get; set; }

    public string? UCmpVers { get; set; }
}
