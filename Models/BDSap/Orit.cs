using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSap;

public partial class Orit
{
    public string Code { get; set; } = null!;

    public string? Name { get; set; }

    public string? IncPartPay { get; set; }

    public int? DayInMonth { get; set; }

    public string? OrigRate { get; set; }
}
