using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSap;

public partial class Opyd
{
    public string Code { get; set; } = null!;

    public string? Name { get; set; }

    public short? TolerDays { get; set; }

    public decimal? MinCashDis { get; set; }

    public string? UseMinPay { get; set; }

    public decimal? MinPayAr { get; set; }

    public decimal? MinPayAp { get; set; }

    public string? ArePayMeth { get; set; }
}
