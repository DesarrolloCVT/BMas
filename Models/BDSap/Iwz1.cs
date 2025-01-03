using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSap;

public partial class Iwz1
{
    public int AbsEntry { get; set; }

    public string AcctCode { get; set; } = null!;

    public string? ActName { get; set; }

    public decimal? ActFrmBlnc { get; set; }

    public string? ExecutLine { get; set; }

    public string? ActRevCncl { get; set; }

    public string? RevToAct { get; set; }

    public decimal? ActDiffBal { get; set; }

    public DateTime? RvCaclDate { get; set; }

    public int? ErrReason { get; set; }

    public decimal? ActLastBal { get; set; }
}
