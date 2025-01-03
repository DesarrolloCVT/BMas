using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSap;

public partial class Wdd2
{
    public int WddCode { get; set; }

    public int CondId { get; set; }

    public short? OpCode { get; set; }

    public string? OpValue { get; set; }
}
