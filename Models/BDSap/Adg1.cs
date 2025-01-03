using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSap;

public partial class Adg1
{
    public int AbsEntry { get; set; }

    public string ObjType { get; set; } = null!;

    public string ObjKey { get; set; } = null!;

    public string? DiscType { get; set; }

    public decimal? Discount { get; set; }

    public decimal? PayFor { get; set; }

    public decimal? ForFree { get; set; }

    public decimal? UpTo { get; set; }

    public int LogInstanc { get; set; }
}
