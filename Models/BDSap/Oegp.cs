using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSap;

public partial class Oegp
{
    public string EmlGrpCode { get; set; } = null!;

    public string? EmlGrpName { get; set; }

    public string? Locked { get; set; }

    public string? DataSource { get; set; }

    public int? UserSign { get; set; }

    public int? LogInstanc { get; set; }
}
