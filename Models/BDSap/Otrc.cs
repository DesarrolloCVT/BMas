using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSap;

public partial class Otrc
{
    public string TrnsCode { get; set; } = null!;

    public string? TrnsCodDsc { get; set; }

    public string? Locked { get; set; }

    public string? DataSource { get; set; }

    public short? UserSign { get; set; }

    public string? Pcn874Ctg { get; set; }
}
