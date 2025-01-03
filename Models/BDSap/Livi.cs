using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSap;

public partial class Livi
{
    public int LogEntry { get; set; }

    public int? Version { get; set; }

    public string? PatchLevel { get; set; }

    public string? Comment { get; set; }

    public string? LoadCustom { get; set; }

    public int? LastMsgId { get; set; }

    public DateTime? UpdateDate { get; set; }

    public string? InitMap { get; set; }

    public string? InitStd { get; set; }
}
