using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSap;

public partial class Arsc6
{
    public string ResCode { get; set; } = null!;

    public int WeekDay { get; set; }

    public decimal? CapFactor1 { get; set; }

    public decimal? CapFactor2 { get; set; }

    public decimal? CapFactor3 { get; set; }

    public decimal? CapFactor4 { get; set; }

    public decimal? CapTotal { get; set; }

    public string? Remarks { get; set; }

    public int LogInstanc { get; set; }

    public decimal? SngRunCap { get; set; }
}
