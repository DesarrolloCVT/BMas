using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSap;

public partial class Obgt
{
    public int AbsId { get; set; }

    public string AcctCode { get; set; } = null!;

    public int? BgdCode { get; set; }

    public string? FatherCode { get; set; }

    public decimal? FthrPrcnt { get; set; }

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

    public decimal? FtrOcrlsum { get; set; }

    public decimal? FtrOdrssum { get; set; }

    public decimal? FtrOcrssum { get; set; }

    public DateTime FinancYear { get; set; }

    public int Instance { get; set; }

    public short? UserSign { get; set; }

    public short? Scncounter { get; set; }
}
