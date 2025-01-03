using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSap;

public partial class Oalc
{
    public string AlcCode { get; set; } = null!;

    public string? AlcName { get; set; }

    public string? OhType { get; set; }

    public string? AcctCode { get; set; }

    public string? DataSource { get; set; }

    public short? UserSign { get; set; }

    public string? LaCallcAcc { get; set; }

    public string? CostCateg { get; set; }
}
