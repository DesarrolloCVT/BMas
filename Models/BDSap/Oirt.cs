using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSap;

public partial class Oirt
{
    public int Numerator { get; set; }

    public DateTime? EffectDate { get; set; }

    public decimal? AnlIntrst { get; set; }

    public string? DataSource { get; set; }

    public short? UserSign { get; set; }
}
