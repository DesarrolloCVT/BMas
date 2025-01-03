using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSap;

public partial class Awtt
{
    public int WttypeId { get; set; }

    public string Wttype { get; set; } = null!;

    public decimal? Wtthresh { get; set; }

    public int LogInstanc { get; set; }

    public short? UserSign2 { get; set; }

    public DateTime? UpdateDate { get; set; }
}
