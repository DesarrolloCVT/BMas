using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSap;

public partial class Wtd2
{
    public int AbsEntry { get; set; }

    public DateTime? EfctFrom { get; set; }

    public decimal? ValueFrom { get; set; }

    public decimal? Rate { get; set; }

    public string? Wtcur { get; set; }

    public int? LogInstanc { get; set; }

    public int LineNum { get; set; }

    public int SeqNum { get; set; }
}
