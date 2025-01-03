using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSap;

public partial class Oidx
{
    public string IdexCode { get; set; } = null!;

    public string? IndexName { get; set; }

    public string? Locked { get; set; }

    public string? DataSource { get; set; }

    public short? UserSign { get; set; }
}
