using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSap;

public partial class Drn2
{
    public int DocEntry { get; set; }

    public string? AcctDtn { get; set; }

    public string ItemCode { get; set; } = null!;

    public decimal? OrdDprAmt { get; set; }

    public decimal? SpDprAmt { get; set; }

    public decimal? RevReserve { get; set; }

    public string AssetClass { get; set; } = null!;
}
