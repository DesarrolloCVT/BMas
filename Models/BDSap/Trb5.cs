using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSap;

public partial class Trb5
{
    public int AbsEntry { get; set; }

    public string State { get; set; } = null!;

    public string? CardCode { get; set; }

    public decimal? TransCrdt { get; set; }

    public decimal? TotalDbt { get; set; }

    public decimal? TtlDbtSc { get; set; }

    public decimal? TotalCrdt { get; set; }

    public decimal? TtlCrdtSc { get; set; }

    public decimal? TotalDed { get; set; }

    public decimal? TtlDedSc { get; set; }

    public decimal? BlncDue { get; set; }

    public int? TransId { get; set; }
}
