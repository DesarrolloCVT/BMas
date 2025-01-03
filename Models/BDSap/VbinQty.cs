using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSap;

public partial class VbinQty
{
    public int BinAbs { get; set; }

    public decimal? ItemQty { get; set; }

    public int? ItemsNum { get; set; }

    public int? SnBnum { get; set; }

    public int? ItemWeight { get; set; }
}
