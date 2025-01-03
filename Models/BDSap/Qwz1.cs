using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSap;

public partial class Qwz1
{
    public string Code { get; set; } = null!;

    public int Numerator { get; set; }

    public string? FileCode { get; set; }

    public string? IsTemp { get; set; }

    public string? DoJoin { get; set; }

    public int? JoinToTbl { get; set; }

    public int? NumOfConds { get; set; }

    public string? OuterJoin { get; set; }

    public string? RightJoin { get; set; }
}
