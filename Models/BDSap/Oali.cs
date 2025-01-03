using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSap;

public partial class Oali
{
    public string OrigItem { get; set; } = null!;

    public string AltItem { get; set; } = null!;

    public decimal? Match { get; set; }

    public string? Remarks { get; set; }
}
