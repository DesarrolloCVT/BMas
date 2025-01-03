using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSap;

public partial class Adt1
{
    public string Code { get; set; } = null!;

    public int Level { get; set; }

    public string? Base { get; set; }

    public int? Years { get; set; }

    public decimal? Percentage { get; set; }

    public int LogInstanc { get; set; }

    public decimal? Amount { get; set; }

    public int? SnapshotId { get; set; }
}
