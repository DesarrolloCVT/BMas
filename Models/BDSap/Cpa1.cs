using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSap;

public partial class Cpa1
{
    public int AbsEntry { get; set; }

    public int LineNum { get; set; }

    public int? LogInstanc { get; set; }

    public string? AcctFrom { get; set; }

    public string? AcctTo { get; set; }
}
