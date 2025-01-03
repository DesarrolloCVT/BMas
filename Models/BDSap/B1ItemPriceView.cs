using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSap;

public partial class B1ItemPriceView
{
    public string ItemCode { get; set; } = null!;

    public short PriceList { get; set; }

    public int? UomEntry { get; set; }

    public decimal? Price { get; set; }

    public string? Currency { get; set; }

    public string? PriceType { get; set; }
}
