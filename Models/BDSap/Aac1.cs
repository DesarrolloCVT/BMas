using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSap;

public partial class Aac1
{
    public string Code { get; set; } = null!;

    public int LineNum { get; set; }

    public string DprAreaId { get; set; } = null!;

    public string? Active { get; set; }

    public string? AcctDtn { get; set; }

    public string? DprTypId { get; set; }

    public int? UseLife { get; set; }

    public int LogInstanc { get; set; }

    public int? SnapshotId { get; set; }
}
