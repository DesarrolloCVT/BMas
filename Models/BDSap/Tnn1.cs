using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSap;

public partial class Tnn1
{
    public int FormCode { get; set; }

    public string Box1099 { get; set; } = null!;

    public string? BoxDescr { get; set; }

    public short? UserSign { get; set; }

    public string? Locked { get; set; }

    public decimal? Min1099Amt { get; set; }
}
