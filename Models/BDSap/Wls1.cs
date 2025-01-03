using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSap;

public partial class Wls1
{
    public int? WfinstId { get; set; }

    public int TaskId { get; set; }

    public short LineId { get; set; }

    public string? Candidate { get; set; }

    public int? LogIns { get; set; }

    public string? WasRead { get; set; }

    public string? CandExpr { get; set; }
}
