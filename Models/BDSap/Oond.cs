using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSap;

public partial class Oond
{
    public int IndCode { get; set; }

    public string IndName { get; set; } = null!;

    public string? IndDesc { get; set; }
}
