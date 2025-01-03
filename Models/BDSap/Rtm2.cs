using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSap;

public partial class Rtm2
{
    public int LineNum { get; set; }

    public string IsSysCurr { get; set; } = null!;

    public string CardCode { get; set; } = null!;

    public string AcctCode { get; set; } = null!;

    public decimal? TransAmtSc { get; set; }

    public decimal? BalDueSc { get; set; }
}
