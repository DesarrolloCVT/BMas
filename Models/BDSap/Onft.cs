using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSap;

public partial class Onft
{
    public int AbsId { get; set; }

    public string Code { get; set; } = null!;

    public string? Locked { get; set; }

    public int? Gpcid { get; set; }

    public string? Cestrel { get; set; }
}
