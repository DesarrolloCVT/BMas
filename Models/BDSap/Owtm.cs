using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSap;

public partial class Owtm
{
    public int WtmCode { get; set; }

    public string Name { get; set; } = null!;

    public string? Remarks { get; set; }

    public string? Conds { get; set; }

    public string? Active { get; set; }

    public short? UserSign { get; set; }

    public string? PmptChg { get; set; }

    public string? AppOnUpd { get; set; }
}
