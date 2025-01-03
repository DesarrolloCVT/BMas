using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSap;

public partial class Ormk
{
    public int AbsId { get; set; }

    public string Code { get; set; } = null!;

    public string? Particular { get; set; }
}
