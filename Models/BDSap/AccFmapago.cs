using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSap;

public partial class AccFmapago
{
    public string Code { get; set; } = null!;

    public string Name { get; set; } = null!;

    public string? UCndpago { get; set; }

    public string? UFmaPago { get; set; }
}
