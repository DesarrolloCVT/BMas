using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSap;

public partial class Ocpl
{
    public int AbsEntry { get; set; }

    public DateTime? StartDate { get; set; }

    public string? StartTime { get; set; }

    public DateTime? EndDate { get; set; }

    public string? EndTime { get; set; }

    public string? CopySource { get; set; }

    public string? CopyTarget { get; set; }

    public string? UserName { get; set; }

    public short? CopyMethod { get; set; }

    public short? FailRpn { get; set; }

    public string? MissingUdf { get; set; }

    public short? CopyType { get; set; }

    public string? ErrorNum { get; set; }

    public short? NullifyAct { get; set; }

    public short? CopyEmtVal { get; set; }
}
