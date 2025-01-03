using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSap;

public partial class Owgt
{
    public short UnitCode { get; set; }

    public string UnitDisply { get; set; } = null!;

    public string UnitName { get; set; } = null!;

    public decimal? WightInMg { get; set; }

    public string? Locked { get; set; }

    public string? DataSource { get; set; }

    public short? UserSign { get; set; }
}
