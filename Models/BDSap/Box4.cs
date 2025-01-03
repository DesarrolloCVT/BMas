using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSap;

public partial class Box4
{
    public string ReportType { get; set; } = null!;

    public DateTime? EffecDate { get; set; }

    public string BoxCode { get; set; } = null!;

    public string Account { get; set; } = null!;

    public string ContraAct { get; set; } = null!;

    public int? SeqNum { get; set; }

    public int BosCode { get; set; }
}
