using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSap;

public partial class Kpi2
{
    public int AbsEntry { get; set; }

    public int? Kpientry { get; set; }

    public string? Type { get; set; }

    public decimal? From { get; set; }

    public decimal? To { get; set; }

    public string? Color { get; set; }
}
