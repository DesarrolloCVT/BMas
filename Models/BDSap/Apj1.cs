using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSap;

public partial class Apj1
{
    public int DocEntry { get; set; }

    public int StepCode { get; set; }

    public int? Father { get; set; }

    public int? VisOrder { get; set; }

    public int? Level { get; set; }

    public string? StepName { get; set; }

    public string? StepInfo { get; set; }

    public string? StepNotes { get; set; }

    public string? StepLink { get; set; }

    public DateTime? StartDate { get; set; }

    public DateTime? EndDate { get; set; }

    public string? IsComplete { get; set; }

    public int LogInstanc { get; set; }

    public string? Owner { get; set; }

    public int? Status { get; set; }

    public decimal? Duration { get; set; }

    public decimal? PlanTime { get; set; }

    public int? AtcEntry { get; set; }

    public decimal? TotalPtime { get; set; }

    public int? QueryId { get; set; }
}
