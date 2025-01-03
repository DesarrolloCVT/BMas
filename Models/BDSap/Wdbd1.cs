using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSap;

public partial class Wdbd1
{
    public string ParentId { get; set; } = null!;

    public string Guid { get; set; } = null!;

    public int? UserId { get; set; }

    public string? Content { get; set; }

    public string? Sys { get; set; }

    public string? Version { get; set; }
}
