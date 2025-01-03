using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSap;

public partial class Oibq
{
    public int AbsEntry { get; set; }

    public string ItemCode { get; set; } = null!;

    public int BinAbs { get; set; }

    public decimal? OnHandQty { get; set; }

    public string? WhsCode { get; set; }

    public string? Freezed { get; set; }

    public int? FreezeDoc { get; set; }
}
