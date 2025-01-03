using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSap;

public partial class View
{
    public string ViewName { get; set; } = null!;

    public string? ViewString { get; set; }

    public string? ViewType { get; set; }
}
