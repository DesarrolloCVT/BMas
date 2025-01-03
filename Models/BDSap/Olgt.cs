using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSap;

public partial class Olgt
{
    public short UnitCode { get; set; }

    public string UnitDisply { get; set; } = null!;

    public string UnitName { get; set; } = null!;

    public string? VolDisply { get; set; }

    public decimal? SizeInMm { get; set; }

    public string? Locked { get; set; }

    public string? DataSource { get; set; }

    public short? UserSign { get; set; }
}
