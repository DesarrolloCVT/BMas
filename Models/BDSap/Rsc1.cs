using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSap;

public partial class Rsc1
{
    public string ResCode { get; set; } = null!;

    public string WhsCode { get; set; } = null!;

    public string? Locked { get; set; }

    public string? ObjType { get; set; }

    public int? LogInstanc { get; set; }
}
