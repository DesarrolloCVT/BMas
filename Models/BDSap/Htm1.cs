using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSap;

public partial class Htm1
{
    public int TeamId { get; set; }

    public short? Line { get; set; }

    public int EmpId { get; set; }

    public string? Role { get; set; }

    public int? LogInstanc { get; set; }
}
