using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSap;

public partial class Owfi
{
    public int WfinstId { get; set; }

    public int? ExecId { get; set; }

    public int? TemplateId { get; set; }

    public string? Creator { get; set; }

    public string? Status { get; set; }

    public DateTime? StartDate { get; set; }

    public short? StartTime { get; set; }

    public short? EndTime { get; set; }

    public DateTime? EndDate { get; set; }

    public short? IsAutoStar { get; set; }
}
