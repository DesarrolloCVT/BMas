using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSap;

public partial class Asp2
{
    public string ItemCode { get; set; } = null!;

    public string CardCode { get; set; } = null!;

    public short Spp1lnum { get; set; }

    public short Spp2lnum { get; set; }

    public decimal? Amount { get; set; }

    public decimal? Price { get; set; }

    public string? Currency { get; set; }

    public decimal? Discount { get; set; }

    public short? UomEntry { get; set; }

    public int LogInstanc { get; set; }

    public string UExxIntegra { get; set; } = null!;

    public string? UX4rInterkey { get; set; }
}
