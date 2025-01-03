using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSap;

public partial class Gbi1
{
    public int HistoryId { get; set; }

    public int RowId { get; set; }

    public string? AcctBkNo { get; set; }

    public string? AcctBkName { get; set; }

    public string? OrgCode { get; set; }

    public string? CompType { get; set; }

    public string? Industry { get; set; }

    public string? SoftVender { get; set; }

    public string? Version { get; set; }

    public string? FisYear { get; set; }

    public string? LocCurr { get; set; }

    public string? AcctStruct { get; set; }
}
