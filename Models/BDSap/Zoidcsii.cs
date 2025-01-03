using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSap;

public partial class Zoidcsii
{
    public string Code { get; set; } = null!;

    public string Name { get; set; } = null!;

    public string UTipo { get; set; } = null!;

    public string? UCodsii { get; set; }

    public string? UDepcripsii { get; set; }

    public string? UIndicador { get; set; }
}
