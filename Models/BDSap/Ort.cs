using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSap;

public partial class Ort
{
    public DateTime RateDate { get; set; }

    public string Currency { get; set; } = null!;

    public decimal? Rate { get; set; }

    public string? DataSource { get; set; }

    public short? UserSign { get; set; }

    public string ReportType { get; set; } = null!;

    public int? LogInstanc { get; set; }

    public DateTime? UpdateDate { get; set; }

    public int? UserSign2 { get; set; }
}
