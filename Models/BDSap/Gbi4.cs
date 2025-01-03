using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSap;

public partial class Gbi4
{
    public int HistoryId { get; set; }

    public int RowId { get; set; }

    public string? Bpno { get; set; }

    public string? Bpname { get; set; }

    public short? CatNo { get; set; }

    public string? Loc { get; set; }

    public string? Tel { get; set; }

    public string? Address { get; set; }

    public string? CreditRank { get; set; }
}
