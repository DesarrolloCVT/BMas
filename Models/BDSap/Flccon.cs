using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSap;

public partial class Flccon
{
    public string Code { get; set; } = null!;

    public string Name { get; set; } = null!;

    public string? UImputable { get; set; }

    public string? UCodPadre { get; set; }

    public string? UAsig { get; set; }
}
