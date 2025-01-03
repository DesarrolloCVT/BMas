using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSap;

public partial class Box3
{
    public string BoxCode { get; set; } = null!;

    public string ReportType { get; set; } = null!;

    public string Value { get; set; } = null!;

    public string? Descr { get; set; }

    public DateTime? EffecDate { get; set; }

    public int BosCode { get; set; }

    public string? IsDefault { get; set; }
}
