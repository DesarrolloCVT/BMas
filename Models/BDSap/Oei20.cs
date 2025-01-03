using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSap;

public partial class Oei20
{
    public int DocEntry { get; set; }

    public int? ExpnsCode { get; set; }

    public decimal? TotalLc { get; set; }

    public decimal? TotalFc { get; set; }

    public decimal? TotalSc { get; set; }

    public string? DistribM { get; set; }

    public decimal? DrawnLc { get; set; }

    public decimal? DrawnFc { get; set; }

    public decimal? DrawnSc { get; set; }

    public int LineNum { get; set; }

    public int? BaseAbsEnt { get; set; }

    public int? BaseType { get; set; }

    public int? BaseRef { get; set; }

    public int? BaseLnNum { get; set; }

    public int? LogInstanc { get; set; }

    public string? ObjectType { get; set; }

    public string? FixCurr { get; set; }

    public decimal? AppliedLc { get; set; }

    public decimal? AppliedFc { get; set; }

    public decimal? AppliedSc { get; set; }
}
