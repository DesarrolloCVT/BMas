using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSap;

public partial class Oarg
{
    public short CstGrpCode { get; set; }

    public string CstGrpName { get; set; } = null!;

    public string? GroupNum { get; set; }

    public decimal? Custom { get; set; }

    public decimal? BuyTax { get; set; }

    public decimal? OtherTax { get; set; }

    public decimal? TotalTax { get; set; }

    public string? Locked { get; set; }

    public string? DataSource { get; set; }

    public short? UserSign { get; set; }

    public string? CstAllcAcc { get; set; }

    public string? CstExpAcc { get; set; }

    public string? PortAddr { get; set; }

    public string? PortState { get; set; }

    public string? ExciExpAcc { get; set; }

    public string? ExciAlcAcc { get; set; }
}
