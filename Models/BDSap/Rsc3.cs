using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSap;

public partial class Rsc3
{
    public string ResCode { get; set; } = null!;

    public string ItemCode { get; set; } = null!;

    public int? LogInstanc { get; set; }
}
