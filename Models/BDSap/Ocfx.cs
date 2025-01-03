using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSap;

public partial class Ocfx
{
    public string ObjType { get; set; } = null!;

    public int? Level { get; set; }

    public string? ObjName { get; set; }

    public string? Group { get; set; }
}
