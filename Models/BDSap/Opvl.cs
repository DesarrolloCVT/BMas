using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSap;

public partial class Opvl
{
    public int Code { get; set; }

    public string? Name { get; set; }

    public string ConsolNum { get; set; } = null!;

    public string? DataSource { get; set; }

    public short? UserSign { get; set; }
}
