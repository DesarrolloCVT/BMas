using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSap;

public partial class Osbq
{
    public int AbsEntry { get; set; }

    public string? ItemCode { get; set; }

    public int SnBmdabs { get; set; }

    public int BinAbs { get; set; }

    public decimal? OnHandQty { get; set; }

    public string? WhsCode { get; set; }
}
