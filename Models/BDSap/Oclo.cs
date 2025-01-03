using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSap;

public partial class Oclo
{
    public short Code { get; set; }

    public string Name { get; set; } = null!;

    public string? DataSource { get; set; }

    public short? UserSign { get; set; }

    public string? Locked { get; set; }
}
