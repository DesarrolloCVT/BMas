using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSap;

public partial class Awl2
{
    public int? WfinstId { get; set; }

    public int TaskId { get; set; }

    public int LineId { get; set; }

    public string? ObjectType { get; set; }

    public string? ObjKey { get; set; }

    public string? Command { get; set; }

    public int LogIns { get; set; }

    public string? ObjSubType { get; set; }

    public string? ObjDetail { get; set; }
}
