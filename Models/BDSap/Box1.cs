using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSap;

public partial class Box1
{
    public string BoxCode { get; set; } = null!;

    public string? BoxMember { get; set; }

    public string? Vatmember { get; set; }

    public int SeqNum { get; set; }

    public string? FormulSign { get; set; }

    public string ReportType { get; set; } = null!;

    public DateTime? EffecDate { get; set; }

    public string? TaxType { get; set; }

    public int BosCode { get; set; }
}
