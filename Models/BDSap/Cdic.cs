using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSap;

public partial class Cdic
{
    public string Namespace { get; set; } = null!;

    public string Key { get; set; } = null!;

    public string? Value { get; set; }
}
