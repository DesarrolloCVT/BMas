using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSap;

public partial class Gbi15
{
    public int HistoryId { get; set; }

    public int RowId { get; set; }

    public string? ItemName { get; set; }

    public string? LineNum { get; set; }

    public decimal? CurMonAmnt { get; set; }

    public decimal? CurYrAmnt { get; set; }
}
