using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSap;

public partial class Pmv8
{
    public int DocNum { get; set; }

    public int LineNum { get; set; }

    public string? InvType { get; set; }

    public int? DocEntry { get; set; }

    public int? DocLine { get; set; }

    public string? ObjectType { get; set; }

    public int? LogInstanc { get; set; }

    public int? PaidEntry { get; set; }

    public int? PaidLine { get; set; }
}
