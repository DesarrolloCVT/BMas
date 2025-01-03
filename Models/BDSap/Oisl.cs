using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSap;

public partial class Oisl
{
    public int LogEntry { get; set; }

    public string? TaskType { get; set; }

    public int? RunId { get; set; }

    public int? Version { get; set; }

    public string? PatchLevel { get; set; }

    public int? LastMsgId { get; set; }

    public DateTime? FinishDate { get; set; }

    public short? FinishTime { get; set; }

    public string? UserCode { get; set; }

    public string? Status { get; set; }

    public string? InitMap { get; set; }

    public string? InitStd { get; set; }
}
