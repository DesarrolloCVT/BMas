using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSap;

public partial class Drn1
{
    public int DocEntry { get; set; }

    public string? AcctDtn { get; set; }

    public int? TransId { get; set; }

    public string? OrdDprAct { get; set; }

    public string? SpDprAct { get; set; }

    public string? SpBalAct { get; set; }

    public string? OrdBalAct { get; set; }

    public decimal? OrdDprAmt { get; set; }

    public decimal? SpDprAmt { get; set; }

    public string? RevResAct { get; set; }

    public string? RevResClr { get; set; }

    public decimal? RevReserve { get; set; }

    public string AssetClass { get; set; } = null!;

    public int? CancelId { get; set; }
}
