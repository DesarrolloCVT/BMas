using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSap;

public partial class Ocl
{
    public short Code { get; set; }

    public string Name { get; set; } = null!;

    public short Type { get; set; }

    public string? DataSource { get; set; }

    public short? UserSign { get; set; }

    public string? Active { get; set; }
}
