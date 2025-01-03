using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSap;

public partial class SmmVwDatoProdRecepcion
{
    public string ItemCode { get; set; } = null!;

    public string? ItemName { get; set; }

    public string? UgpName { get; set; }

    public decimal? BaseQty { get; set; }

    public int UgpEntry { get; set; }

    public string BcdCode { get; set; } = null!;

    public int UomEntry { get; set; }

    public string UomCode { get; set; } = null!;
}
