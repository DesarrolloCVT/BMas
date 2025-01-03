using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSap;

public partial class Onoa
{
    public int AbsId { get; set; }

    public string Code { get; set; } = null!;

    public string? Descr { get; set; }

    public string? AsseType { get; set; }
}
