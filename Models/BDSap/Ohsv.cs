using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSap;

public partial class Ohsv
{
    public string RecordKey { get; set; } = null!;

    public string? Ref1 { get; set; }

    public string? Ref2 { get; set; }

    public string? RefDate { get; set; }

    public string? DueDate { get; set; }

    public string? CurrCode { get; set; }

    public string? Memo { get; set; }

    public string? DebAcct1 { get; set; }

    public string? CredAcct1 { get; set; }

    public string? DebAmnt1 { get; set; }

    public string? CredAmnt1 { get; set; }

    public string? FdebAmnt1 { get; set; }

    public string? FcredAmnt1 { get; set; }

    public string? Filler { get; set; }

    public string? EndField { get; set; }
}
