using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSap;

public partial class Awo4
{
    public int DocEntry { get; set; }

    public int StageId { get; set; }

    public int SeqNum { get; set; }

    public int? StgEntry { get; set; }

    public string? Name { get; set; }

    public int LogInstanc { get; set; }

    public DateTime? StartDate { get; set; }

    public DateTime? EndDate { get; set; }

    public string? Status { get; set; }

    public decimal? RtCalcProp { get; set; }

    public decimal? ReqDays { get; set; }

    public decimal? WaitDays { get; set; }
}
