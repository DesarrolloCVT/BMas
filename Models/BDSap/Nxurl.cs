using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSap;

public partial class Nxurl
{
    public string Code { get; set; } = null!;

    public string Name { get; set; } = null!;

    public string? UNxurl { get; set; }

    public string? UNxnombre { get; set; }

    public string? UNxuser { get; set; }
}
