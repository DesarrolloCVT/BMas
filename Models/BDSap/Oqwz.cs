using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSap;

public partial class Oqwz
{
    public string Code { get; set; } = null!;

    public string Name { get; set; } = null!;

    public short? UserSign { get; set; }
}
