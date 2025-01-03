using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSap;

public partial class Ocqg
{
    public short GroupCode { get; set; }

    public string GroupName { get; set; } = null!;

    public short? UserSign { get; set; }

    public string? Filler { get; set; }
}
