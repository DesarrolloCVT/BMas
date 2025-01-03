using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSap;

public partial class Owin
{
    public int Id { get; set; }

    public int? WfinstId { get; set; }

    public int? TaskId { get; set; }

    public string? ProcDefId { get; set; }

    public string? FlowElemId { get; set; }

    public string? InfoType { get; set; }

    public string? InfoCode { get; set; }

    public string? Desc { get; set; }

    public DateTime? CreateDate { get; set; }

    public int? CreateTime { get; set; }

    public string? IsRead { get; set; }
}
