using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSap;

public partial class Opbd
{
    public string Code { get; set; } = null!;

    public string? Descriptio { get; set; }

    public string? Default { get; set; }
}
