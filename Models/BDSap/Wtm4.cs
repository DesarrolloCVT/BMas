using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSap;

public partial class Wtm4
{
    public int WtmCode { get; set; }

    public int CondId { get; set; }

    public short? OpCode { get; set; }

    public string? OpValue { get; set; }
}
