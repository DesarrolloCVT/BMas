using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSap;

public partial class Mth1v
{
    public string MthAcctCod { get; set; } = null!;

    public string IsInternal { get; set; } = null!;

    public int MatchNum { get; set; }

    public int TransId { get; set; }

    public int LineId { get; set; }

    public DateTime? RefDate { get; set; }

    public DateTime? DueDate { get; set; }

    public string? Ref1 { get; set; }

    public string? Ref2 { get; set; }

    public string? Ref3Line { get; set; }

    public decimal? Debit { get; set; }

    public decimal? Credit { get; set; }

    public decimal? Sysdeb { get; set; }

    public decimal? Syscred { get; set; }

    public decimal? Fcdebit { get; set; }

    public decimal? Fccredit { get; set; }

    public string? Currency { get; set; }

    public string? LineMemo { get; set; }
}
