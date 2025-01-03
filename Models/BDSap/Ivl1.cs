using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSap;

public partial class Ivl1
{
    public int TransSeq { get; set; }

    public int LayerId { get; set; }

    public decimal? CalcPrice { get; set; }

    public decimal? Balance { get; set; }

    public decimal? TransValue { get; set; }

    public decimal? LayerInQty { get; set; }

    public decimal? LayerOutQ { get; set; }

    public decimal? RevalTotal { get; set; }
}
