using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSap;

public partial class Itt2
{
    public string Father { get; set; } = null!;

    public int StageId { get; set; }

    public int SeqNum { get; set; }

    public int? StgEntry { get; set; }

    public string? Name { get; set; }

    public int? LogInstanc { get; set; }

    public decimal? WaitDays { get; set; }
}
