using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSap;

public partial class Ocest
{
    public int AbsId { get; set; }

    public string Cest { get; set; } = null!;

    public string? Descr { get; set; }

    public int? LogInstanc { get; set; }
}
