using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSap;

public partial class Awh3
{
    public int? AbsId { get; set; }

    public string Wtcode { get; set; } = null!;

    public DateTime? EfctFrom { get; set; }

    public decimal? ValueFrom { get; set; }

    public decimal? Deduct { get; set; }

    public decimal? Rate { get; set; }

    public string? Wtcur { get; set; }

    public int LogInstanc { get; set; }

    public int LineNum { get; set; }

    public int SeqNum { get; set; }
}
