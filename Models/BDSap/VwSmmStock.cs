using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSap;

public partial class VwSmmStock
{
    public string Itemcode { get; set; } = null!;

    public int? Stock { get; set; }

    public int UomEntry { get; set; }

    public string UomCode { get; set; } = null!;

    public string BcdCode { get; set; } = null!;
}
