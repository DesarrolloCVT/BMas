using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSap;

public partial class Owdbd
{
    public string Guid { get; set; } = null!;

    public int? UserId { get; set; }

    public string? Content { get; set; }

    public string? Sys { get; set; }
}
