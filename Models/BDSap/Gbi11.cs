using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSap;

public partial class Gbi11
{
    public int HistoryId { get; set; }

    public int RowId { get; set; }

    public string? ItemName { get; set; }

    public decimal? Bopbalance { get; set; }

    public decimal? CurDebit { get; set; }

    public decimal? CurCredit { get; set; }

    public decimal? Eopbalance { get; set; }
}
