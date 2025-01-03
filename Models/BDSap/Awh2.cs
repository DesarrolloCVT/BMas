using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSap;

public partial class Awh2
{
    public int? AbsEntry { get; set; }

    public string Code { get; set; } = null!;

    public DateTime? EffectDate { get; set; }

    public decimal? Rate { get; set; }

    public decimal? MinAmount { get; set; }

    public decimal? MaxAmount { get; set; }

    public string? Wtcur { get; set; }

    public int LogInstanc { get; set; }

    public int LineNum { get; set; }

    public int SeqNum { get; set; }
}
