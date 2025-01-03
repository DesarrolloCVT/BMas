using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSap;

public partial class Oppt
{
    public string Code { get; set; } = null!;

    public string? Descriptio { get; set; }

    public string? Default { get; set; }
}
