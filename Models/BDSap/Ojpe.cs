using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSap;

public partial class Ojpe
{
    public string Code { get; set; } = null!;

    public string? EraName { get; set; }

    public DateTime? StartDate { get; set; }
}
