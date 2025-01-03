using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSap;

public partial class Msn2
{
    public int AbsEntry { get; set; }

    public string ItemCode { get; set; } = null!;

    public int PeriodId { get; set; }

    public decimal? Initial { get; set; }

    public decimal? InitialOrg { get; set; }

    public decimal? InStock { get; set; }

    public decimal? OutStock { get; set; }

    public decimal? Final { get; set; }

    public decimal? FinalOrg { get; set; }

    public decimal? Requests { get; set; }
}
