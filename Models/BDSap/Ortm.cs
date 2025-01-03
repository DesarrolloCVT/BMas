using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSap;

public partial class Ortm
{
    public int LineNum { get; set; }

    public DateTime? Rtmdate { get; set; }

    public string? AcctCode { get; set; }

    public string? IsCard { get; set; }

    public string? ActCurrncy { get; set; }

    public decimal? ActRate { get; set; }

    public decimal? Balance { get; set; }

    public decimal? FrnBlnc { get; set; }

    public int? TransNum { get; set; }

    public string? Valid { get; set; }

    public decimal? Delta { get; set; }

    public string IsSysCurr { get; set; } = null!;

    public DateTime? StornoDate { get; set; }

    public decimal? RevalRate { get; set; }

    public short? UserSign { get; set; }

    public int? Bplid { get; set; }

    public decimal? CntBlnc { get; set; }

    public decimal? TransAmtSc { get; set; }

    public decimal? BalDueSc { get; set; }

    public string? Scadjust { get; set; }
}
