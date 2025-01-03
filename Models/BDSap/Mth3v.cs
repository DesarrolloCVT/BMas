using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSap;

public partial class Mth3v
{
    public int? AbsEntry { get; set; }

    public string? AcctCdeFrm { get; set; }

    public string? AcctCdeTo { get; set; }

    public string IsInternal { get; set; } = null!;

    public string? IsCard { get; set; }

    public int? MatchNumFr { get; set; }

    public int? MatchNumTo { get; set; }

    public DateTime? MthDateFrm { get; set; }

    public DateTime? MthDateTo { get; set; }

    public string MthAcctCod { get; set; } = null!;

    public int MatchNum { get; set; }
}
