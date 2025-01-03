using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSap;

public partial class Scr1
{
    public short RuleId { get; set; }

    public short CondNum { get; set; }

    public string? Value1 { get; set; }

    public string? Table1 { get; set; }

    public string? Field1 { get; set; }

    public string? Cond1 { get; set; }

    public string? Group1 { get; set; }

    public string? Relation { get; set; }

    public string? Value2 { get; set; }

    public string? Table2 { get; set; }

    public string? Field2 { get; set; }

    public string? Cond2 { get; set; }

    public string? Group2 { get; set; }

    public string? ExtCond1 { get; set; }

    public string? ExtCond2 { get; set; }
}
