using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSap;

public partial class SmmImpuestoProducto
{
    public string Itemcode { get; set; } = null!;

    public string Taxcodear { get; set; } = null!;

    public decimal? Rate { get; set; }
}
