using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSap;

public partial class Omth
{
    public string MthAcctCod { get; set; } = null!;

    public string IsInternal { get; set; } = null!;

    public int MatchNum { get; set; }

    public decimal? Totals { get; set; }

    public string? IsCard { get; set; }

    public string? MatchType { get; set; }

    public int? TransId { get; set; }

    public DateTime? MatchDate { get; set; }

    public string? CurrType { get; set; }

    public string? DataSource { get; set; }

    public short? UserSign { get; set; }

    public DateTime? CreateDate { get; set; }
}
