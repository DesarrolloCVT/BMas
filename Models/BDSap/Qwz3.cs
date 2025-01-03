using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSap;

public partial class Qwz3
{
    public string Code { get; set; } = null!;

    public int Numerator { get; set; }

    public int? OpenBrackt { get; set; }

    public string? FileCode { get; set; }

    public string? FieldAlias { get; set; }

    public int? Operation { get; set; }

    public string? CondVal { get; set; }

    public string? CondEndVal { get; set; }

    public string? CompareFld { get; set; }

    public string? UseRes { get; set; }

    public string? CompTblIdx { get; set; }

    public string? CompFldNum { get; set; }

    public int? Relatship { get; set; }

    public int? ClosBrackt { get; set; }

    public string? FreeText { get; set; }
}
