using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSap;

public partial class Srt1
{
    public string SumRptId { get; set; } = null!;

    public int SeqNo { get; set; }

    public int? CardNum { get; set; }

    public int? TransNum { get; set; }

    public decimal? BaseAmt { get; set; }

    public decimal? TaxAmt { get; set; }
}
