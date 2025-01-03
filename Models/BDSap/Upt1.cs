using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSap;

public partial class Upt1
{
    public string PermId { get; set; } = null!;

    public string FormId { get; set; } = null!;

    public short? VisOrder { get; set; }
}
