using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSap;

public partial class Pjt2
{
    public int DocEntry { get; set; }

    public int StepCode { get; set; }

    public int LineNum { get; set; }

    public DateTime? Date { get; set; }

    public int? StartTime { get; set; }

    public int? EndTime { get; set; }

    public string? Remarks { get; set; }

    public int? LogInstanc { get; set; }

    public string? Owner { get; set; }

    public decimal? Duration { get; set; }
}
