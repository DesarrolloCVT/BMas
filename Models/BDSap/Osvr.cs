using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSap;

public partial class Osvr
{
    public string AcctCode { get; set; } = null!;

    public decimal? EndBalanc { get; set; }

    public DateTime? EndDate { get; set; }

    public int? StatemntNo { get; set; }

    public short? UserSign { get; set; }

    public DateTime? CreateDate { get; set; }
}
