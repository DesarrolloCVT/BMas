using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSap;

public partial class Ogsp
{
    public string Code { get; set; } = null!;

    public string? Name { get; set; }

    public short? UserSign { get; set; }
}
