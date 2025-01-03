using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSap;

public partial class Obox
{
    public string BoxCode { get; set; } = null!;

    public string? BoxName { get; set; }

    public string? BoxType { get; set; }

    public string? SummayFld { get; set; }

    public string? DbtCrdt { get; set; }

    public string? Formula { get; set; }

    public int? SortOrder { get; set; }

    public string? AbsolutVa { get; set; }

    public string ReportType { get; set; } = null!;

    public string? Inactive { get; set; }

    public DateTime? EffecDate { get; set; }

    public string? DecLoc { get; set; }

    public int BosCode { get; set; }

    public string? Position { get; set; }

    public string? PostToAct { get; set; }

    public string? PostToOffA { get; set; }
}
