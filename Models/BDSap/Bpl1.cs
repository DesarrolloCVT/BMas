using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSap;

public partial class Bpl1
{
    public int Bplid { get; set; }

    public string DstState { get; set; } = null!;

    public string? Ienumber { get; set; }

    public int? LogInstanc { get; set; }
}
