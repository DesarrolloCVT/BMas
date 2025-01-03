using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSap;

public partial class Awl4
{
    public string? WfinstId { get; set; }

    public int TaskId { get; set; }

    public string LineId { get; set; } = null!;

    public string? ObjectType { get; set; }

    public string? ObjKey { get; set; }

    public int LogIns { get; set; }

    public string? OutParamId { get; set; }

    public string? ObjSubType { get; set; }
}
