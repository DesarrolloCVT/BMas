using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSap;

public partial class Rsc4
{
    public string ResCode { get; set; } = null!;

    public string EmpId { get; set; } = null!;

    public int? LogInstanc { get; set; }
}
