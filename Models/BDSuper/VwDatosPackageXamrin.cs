using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSuper;

public partial class VwDatosPackageXamrin
{
    public string? PackageSscc { get; set; }

    public string ItemCode { get; set; } = null!;

    public string? ItemName { get; set; }

    public decimal? PackageQuantity { get; set; }

    public string? PackageLot { get; set; }

    public DateTime? FechaProduccion { get; set; }

    public DateTime? FechaVencimiento { get; set; }

    public string? SiteDescription { get; set; }

    public int SiteId { get; set; }

    public int? LayoutId { get; set; }

    public int PackageId { get; set; }
}
