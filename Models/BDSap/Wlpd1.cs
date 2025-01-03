using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSap;

public partial class Wlpd1
{
    public string ParentId { get; set; } = null!;

    public string Guid { get; set; } = null!;

    public int? Order { get; set; }

    public string? GroupId { get; set; }

    public string? GroupName { get; set; }

    public string? Visible { get; set; }
}
