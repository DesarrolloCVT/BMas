using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSap;

public partial class Oddg
{
    public int Numerator { get; set; }

    public string DdgCode { get; set; } = null!;

    public string DdgName { get; set; } = null!;

    public decimal? DdctPrcnt { get; set; }

    public string? DataSource { get; set; }

    public short? UserSign { get; set; }
}
