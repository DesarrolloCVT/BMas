using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSap;

public partial class Rtm1
{
    public int LineNum { get; set; }

    public int TransId { get; set; }

    public int JdtLine { get; set; }

    public string IsSysCurr { get; set; } = null!;

    public string? AcctCode { get; set; }

    public decimal? Balance { get; set; }

    public decimal? FrnBlnc { get; set; }

    public string? Valid { get; set; }

    public decimal? RevalRate { get; set; }

    public decimal? Delta { get; set; }

    public string? Fccurrency { get; set; }

    public string? JdtAcctCod { get; set; }

    public string? BaseRef { get; set; }

    public string? JdtType { get; set; }

    public DateTime? RefDate { get; set; }

    public DateTime? DueDate { get; set; }

    public DateTime? TaxDate { get; set; }

    public int? Bplid { get; set; }

    public decimal? CntBlnc { get; set; }
}
