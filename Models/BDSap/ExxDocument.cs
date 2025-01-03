using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSap;

public partial class ExxDocument
{
    public string Code { get; set; } = null!;

    public string Name { get; set; } = null!;

    public string? UEstado { get; set; }
}
