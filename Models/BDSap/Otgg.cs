using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSap;

public partial class Otgg
{
    public string TargetCode { get; set; } = null!;

    public string? TargetName { get; set; }

    public string? TargetType { get; set; }
}
