using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSap;

public partial class Ojson
{
    public string Guid { get; set; } = null!;

    public string Type { get; set; } = null!;

    public string Index1 { get; set; } = null!;

    public string? Content { get; set; }

    public short? UserSign { get; set; }
}
