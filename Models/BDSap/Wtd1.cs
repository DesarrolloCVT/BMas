using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSap;

public partial class Wtd1
{
    public int AbsEntry { get; set; }

    public int LineNum { get; set; }

    public DateTime? DateFrom { get; set; }

    public decimal? Rate { get; set; }

    public int? LogInstanc { get; set; }
}
