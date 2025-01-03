using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSap;

public partial class Owtj
{
    public int Id { get; set; }

    public string? IsAsync { get; set; }

    public string? Status { get; set; }

    public DateTime? StartDate { get; set; }

    public int? StartTime { get; set; }

    public int? TimerEtyId { get; set; }

    public string? JobHanConf { get; set; }

    public string? JobHanType { get; set; }

    public string? LastUpdate { get; set; }
}
