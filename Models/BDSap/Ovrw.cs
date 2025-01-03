using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSap;

public partial class Ovrw
{
    public int AbsEntry { get; set; }

    public string? RunName { get; set; }

    public DateTime? RunDate { get; set; }

    public string? Status { get; set; }

    public int? UserSign { get; set; }

    public string? LedgerType { get; set; }

    public string? DebitAcc { get; set; }

    public DateTime? PostDate { get; set; }

    public string? Jeseries { get; set; }

    public string? Aptiseries { get; set; }

    public string? DateType { get; set; }

    public DateTime? DateFrom { get; set; }

    public DateTime? DateTo { get; set; }

    public string? IncCorAlt { get; set; }

    public int? Bplid { get; set; }

    public string? RunType { get; set; }
}
