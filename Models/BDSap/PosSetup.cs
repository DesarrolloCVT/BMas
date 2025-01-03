using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSap;

public partial class PosSetup
{
    public string Code { get; set; } = null!;

    public string Name { get; set; } = null!;

    public string? UPosAddn { get; set; }

    public string? UPosVers { get; set; }
}
