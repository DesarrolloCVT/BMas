using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSap;

public partial class Wvt8
{
    public string ParentId { get; set; } = null!;

    public string Guid { get; set; } = null!;

    public string? ChartType { get; set; }

    public string? ShowLegend { get; set; }

    public string? CtgrAxis1 { get; set; }

    public string? CtgrAxis2 { get; set; }

    public string? TimeAxis { get; set; }

    public string? Color { get; set; }

    public string? Shape { get; set; }

    public string? BblWidth { get; set; }
}
