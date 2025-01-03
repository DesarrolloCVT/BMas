using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSap;

public partial class Ovmc
{
    public int AbsEntry { get; set; }

    public int? SysId { get; set; }

    public int? ObjectId { get; set; }

    public string? Type { get; set; }

    public DateTime? StartDate { get; set; }

    public int? StartTime { get; set; }

    public DateTime? EndDate { get; set; }

    public int? EndTime { get; set; }

    public string? Message { get; set; }

    public string? Status { get; set; }
}
