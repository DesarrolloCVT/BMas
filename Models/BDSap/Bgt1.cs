using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSap;

public partial class Bgt1
{
    public int BudgId { get; set; }

    public int LineId { get; set; }

    public decimal? DebLtotal { get; set; }

    public decimal? CredLtotal { get; set; }

    public decimal? DebStotal { get; set; }

    public decimal? CredStotal { get; set; }

    public decimal? DebRltotal { get; set; }

    public decimal? CrdRltotal { get; set; }

    public decimal? DebRstotal { get; set; }

    public decimal? CrdRstotal { get; set; }

    public decimal? FtrIdrlsum { get; set; }

    public decimal? FtrIdrssum { get; set; }

    public decimal? FtrIcrlsum { get; set; }

    public decimal? FtrIcrssum { get; set; }

    public decimal? FtrOdrlsum { get; set; }

    public decimal? FtrOdrssum { get; set; }

    public decimal? FtrOcrlsum { get; set; }

    public decimal? FtrOcrssum { get; set; }

    public decimal? MonthPrcnt { get; set; }

    public string? LineMemo { get; set; }

    public int? Instance { get; set; }

    public string? AcctCode { get; set; }

    public short? UserSign { get; set; }
}
