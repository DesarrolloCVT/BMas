using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSap;

public partial class Rtl1
{
    public int LogEntry { get; set; }

    public int StdCostNum { get; set; }

    public int BaseLogEnt { get; set; }

    public decimal? DocQty { get; set; }

    public decimal? Price { get; set; }

    public decimal? Total { get; set; }

    public decimal? OpenTotal { get; set; }
}
