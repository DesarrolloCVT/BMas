using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSap;

public partial class Tipomarca
{
    public string Code { get; set; } = null!;

    public string Name { get; set; } = null!;

    public string? UMarca { get; set; }
}
