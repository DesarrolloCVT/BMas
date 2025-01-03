using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSap;

public partial class Owti
{
    public int Id { get; set; }

    public string? Name { get; set; }

    public int? TemplateId { get; set; }

    public DateTime? StartDate { get; set; }

    public int? StartTime { get; set; }

    public int? RepeatCnt { get; set; }

    public string? Duration { get; set; }

    public string? LastUpdate { get; set; }

    public DateTime? UnScheStDt { get; set; }

    public int? UnScheStTi { get; set; }

    public int? UnScheReCt { get; set; }

    public string? IsComplete { get; set; }

    public string? JobHanType { get; set; }

    public string? JobHanConf { get; set; }

    public string? IsActive { get; set; }
}
