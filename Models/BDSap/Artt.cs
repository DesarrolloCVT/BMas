using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSap;

public partial class Artt
{
    public DateTime RateDate { get; set; }

    public string Currency { get; set; } = null!;

    public decimal? Rate { get; set; }

    public string? DataSource { get; set; }

    public short? UserSign { get; set; }

    public int LogInstanc { get; set; }

    public DateTime? UpdateDate { get; set; }

    public int? UserSign2 { get; set; }

    public string UExxIntegra { get; set; } = null!;

    public string? UX4rInterkey { get; set; }
}
