using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSap;

public partial class Occ
{
    public string WhsCode { get; set; } = null!;

    public string? CycleType { get; set; }

    public short? CycleBy { get; set; }
}
