using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSap;

public partial class Ccpd
{
    public int PerAbs { get; set; }

    public int LineId { get; set; }

    public string? ProfitAct { get; set; }

    public string? Ref1 { get; set; }

    public string? Ref2 { get; set; }

    public DateTime? DueDate { get; set; }

    public DateTime? RefDate { get; set; }

    public DateTime? TaxDate { get; set; }

    public string? Memo { get; set; }

    public string? MarkLine { get; set; }

    public string? ActKeyLine { get; set; }

    public decimal? LocBalLine { get; set; }

    public decimal? FcBalLine { get; set; }

    public decimal? SysBalLine { get; set; }

    public int? ToPerAbs { get; set; }

    public string? CtrlAct { get; set; }

    public string? PlAccount { get; set; }

    public string? Ref1L { get; set; }

    public string? Ref2L { get; set; }

    public string? Ref3L { get; set; }
}
