using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSap;

public partial class Rit1
{
    public string Code { get; set; } = null!;

    public int LineNum { get; set; }

    public short? Days { get; set; }

    public decimal? IntrstPrct { get; set; }

    public decimal? FixedSum { get; set; }

    public string? FixSumCurr { get; set; }
}
