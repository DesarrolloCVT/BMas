using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSap;

public partial class Gbi2
{
    public int HistoryId { get; set; }

    public int RowId { get; set; }

    public string? AcctCode { get; set; }

    public string? AcctName { get; set; }

    public int? StrucLevel { get; set; }

    public string? EvalSign { get; set; }

    public string? AddField { get; set; }

    public string? AcctType { get; set; }

    public string? MesurUnit { get; set; }

    public string? BlDirect { get; set; }
}
