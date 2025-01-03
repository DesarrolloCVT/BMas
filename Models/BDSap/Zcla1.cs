using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSap;

public partial class Zcla1
{
    public string Code { get; set; } = null!;

    public string Name { get; set; } = null!;

    public string? ULibro { get; set; }

    public short? UClasif { get; set; }
}
