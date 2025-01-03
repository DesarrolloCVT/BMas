using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSap;

public partial class Awl5
{
    public string? WfinstId { get; set; }

    public int TaskId { get; set; }

    public string LineId { get; set; } = null!;

    public int? InputId { get; set; }

    public string? SrcFld { get; set; }

    public string? TgtFld { get; set; }

    public int LogIns { get; set; }
}
