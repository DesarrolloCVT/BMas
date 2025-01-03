using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSap;

public partial class Awt
{
    public int Id { get; set; }

    public string? Owner { get; set; }

    public string? OutputPar { get; set; }

    public string? EndTime { get; set; }

    public string? StartTime { get; set; }

    public int? ProcDefId { get; set; }

    public string? Name { get; set; }

    public int? ExeId { get; set; }

    public int? ProcInsId { get; set; }

    public string? Desc { get; set; }

    public string? InputPar { get; set; }

    public string? DelReason { get; set; }

    public string? Assignee { get; set; }

    public int LogInst { get; set; }

    public string? LastUpdate { get; set; }

    public string? Key { get; set; }

    public int? B1task { get; set; }
}
