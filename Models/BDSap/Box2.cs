using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSap;

public partial class Box2
{
    public string BoxCode { get; set; } = null!;

    public string ReportType { get; set; } = null!;

    public string Account { get; set; } = null!;

    public int? SeqNum { get; set; }

    public DateTime? EffecDate { get; set; }

    public int BosCode { get; set; }
}
