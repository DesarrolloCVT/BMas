using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSap;

public partial class Gbi9
{
    public int HistoryId { get; set; }

    public int RowId { get; set; }

    public string? RepItm { get; set; }

    public string? RepItmNo { get; set; }

    public decimal? PeriodAmt { get; set; }

    public decimal? YearAmt { get; set; }
}
