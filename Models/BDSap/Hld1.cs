using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSap;

public partial class Hld1
{
    public string HldCode { get; set; } = null!;

    public DateTime StrDate { get; set; }

    public DateTime EndDate { get; set; }

    public string? Rmrks { get; set; }
}
