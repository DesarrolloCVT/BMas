using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSap;

public partial class Gbi10
{
    public int HistoryId { get; set; }

    public int RowId { get; set; }

    public string? LineTitle { get; set; }

    public string? LineNum { get; set; }

    public decimal? Amount { get; set; }
}
