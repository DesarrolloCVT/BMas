using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSap;

public partial class Mth2v
{
    public string MthAcctCod { get; set; } = null!;

    public string IsInternal { get; set; } = null!;

    public int MatchNum { get; set; }

    public string BnkAcctCod { get; set; } = null!;

    public int Sequence { get; set; }

    public DateTime? DueDate { get; set; }

    public string? Ref { get; set; }

    public decimal? DebAmount { get; set; }

    public string? Memo { get; set; }
}
