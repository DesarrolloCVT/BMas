using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSap;

public partial class Scm3
{
    public short RuleId { get; set; }

    public short FldNum { get; set; }

    public string? SrcTable { get; set; }

    public string? SrcField { get; set; }

    public string? CalcCase { get; set; }

    public string? CalcTable { get; set; }

    public string? CondCase { get; set; }

    public string? CondTable { get; set; }

    public string? Grouping { get; set; }

    public string? CallProc { get; set; }

    public string? ExtCond { get; set; }
}
