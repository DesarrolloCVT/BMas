using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSap;

public partial class Gbi14
{
    public int HistoryId { get; set; }

    public int RowId { get; set; }

    public string? LineTitle { get; set; }

    public string? LineNum { get; set; }

    public decimal? PreAmount { get; set; }

    public decimal? CurAmount { get; set; }
}
