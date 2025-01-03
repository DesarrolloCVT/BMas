using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSap;

public partial class Tpw4
{
    public int AbsEntry { get; set; }

    public string? RefundAcct { get; set; }

    public decimal? RefundAmnt { get; set; }

    public decimal? RfndAmntFc { get; set; }

    public decimal? RfndAmntSc { get; set; }
}
