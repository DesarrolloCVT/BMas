using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSap;

public partial class Oml
{
    public int Code { get; set; }

    public string Name { get; set; } = null!;

    public string? DataSource { get; set; }

    public short? UserSign { get; set; }
}
