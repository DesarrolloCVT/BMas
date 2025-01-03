using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSap;

public partial class Bnk1
{
    public int IdNumber { get; set; }

    public int Bsline { get; set; }

    public short ListLineId { get; set; }

    public string? DocId { get; set; }

    public decimal? AmntLc { get; set; }

    public decimal? AmnFc { get; set; }

    public string? IsDebit { get; set; }
}
