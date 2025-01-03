using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSap;

public partial class Ait3
{
    public string ItemCode { get; set; } = null!;

    public string? IncNature { get; set; }

    public int LogInstanc { get; set; }

    public string? ObjType { get; set; }
}
