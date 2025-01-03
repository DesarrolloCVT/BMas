using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSap;

public partial class Opr3
{
    public int OpportId { get; set; }

    public short Line { get; set; }

    public int? CompetId { get; set; }

    public string? Memo { get; set; }

    public string? Won { get; set; }

    public short? ThreatLevl { get; set; }

    public string? EncryptIv { get; set; }
}
