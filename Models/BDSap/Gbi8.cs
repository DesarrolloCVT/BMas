using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSap;

public partial class Gbi8
{
    public int HistoryId { get; set; }

    public int RowId { get; set; }

    public string? AcctName { get; set; }

    public string? LineNum { get; set; }

    public decimal? YearBamt { get; set; }

    public decimal? PerEamt { get; set; }

    public string? RepDate { get; set; }
}
