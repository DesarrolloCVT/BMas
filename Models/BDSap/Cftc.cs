using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSap;

public partial class Cftc
{
    public string TabName { get; set; } = null!;

    public string ColName { get; set; } = null!;

    public string? IntLevel { get; set; }
}
