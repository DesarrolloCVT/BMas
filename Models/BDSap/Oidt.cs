using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSap;

public partial class Oidt
{
    public string Idtype { get; set; } = null!;

    public string? Locked { get; set; }

    public string? DataSource { get; set; }

    public short? UserSign { get; set; }
}
