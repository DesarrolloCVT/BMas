using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSuper;

public partial class VwStockFechaTransferencium
{
    public int TransferId { get; set; }

    public int SiteIdDestiny { get; set; }

    public string ItemCode { get; set; } = null!;

    public DateTime? PackageProductionDate { get; set; }

    public decimal? Cantidad { get; set; }
}
