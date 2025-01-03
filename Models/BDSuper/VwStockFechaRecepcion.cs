using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSuper;

public partial class VwStockFechaRecepcion
{
    public int ReceptionId { get; set; }

    public int SiteId { get; set; }

    public string ItemCode { get; set; } = null!;

    public DateTime? PackageProductionDate { get; set; }

    public decimal? Cantidad { get; set; }
}
