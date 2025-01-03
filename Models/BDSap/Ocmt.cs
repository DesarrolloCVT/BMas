using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSap;

public partial class Ocmt
{
    public int CompetId { get; set; }

    public string Name { get; set; } = null!;

    public short? ThreatLevl { get; set; }

    public string? Memo { get; set; }

    public string? DataSource { get; set; }

    public short? UserSign { get; set; }
}
