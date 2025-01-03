using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSap;

public partial class Odab
{
    public int AbsEntry { get; set; }

    public int PackEntry { get; set; }

    public string DashbdCode { get; set; } = null!;

    public string? DashbdName { get; set; }

    public string? DashbdPath { get; set; }

    public string? Note { get; set; }

    public string? Status { get; set; }

    public string? JobFlag { get; set; }

    public string? JobType { get; set; }

    public string? JobSetting { get; set; }

    public DateTime? RenewDate { get; set; }

    public short? RenewTime { get; set; }

    public string? ProcName { get; set; }

    public string? JobName { get; set; }
}
