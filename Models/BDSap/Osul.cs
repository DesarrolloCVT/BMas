using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSap;

public partial class Osul
{
    public int Id { get; set; }

    public string? RealName { get; set; }

    public string? LogReason { get; set; }

    public string? LogDetail { get; set; }

    public string? Mac { get; set; }

    public string? Machine { get; set; }

    public DateTime? StartDate { get; set; }

    public int? StartTime { get; set; }

    public DateTime? EndDate { get; set; }

    public int? EndTime { get; set; }

    public string? ChkHash { get; set; }
}
