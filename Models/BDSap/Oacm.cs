using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSap;

public partial class Oacm
{
    public int AbsId { get; set; }

    public string? CardCode { get; set; }

    public string? Wtcode { get; set; }

    public string? PeriodCat { get; set; }

    public decimal? AcmAmt { get; set; }

    public string? ExcdTransc { get; set; }

    public DateTime? CreateDate { get; set; }

    public DateTime? UpdateDate { get; set; }
}
