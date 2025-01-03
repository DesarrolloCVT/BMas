using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSuper;

public partial class CvtVwFiltroTransferenciasSmm
{
    public int PackageId { get; set; }

    public int? LayoutId { get; set; }

    public string ItemCode { get; set; } = null!;

    public string? ItemName { get; set; }

    public string? PackageSscc { get; set; }

    public int SiteId { get; set; }

    public string? LayoutDescription { get; set; }

    public string? SiteDescription { get; set; }

    public string? PackageLot { get; set; }

    public decimal? PackageQuantity { get; set; }

    public int? ReceptionId { get; set; }

    public string? Medida { get; set; }

    public int? BaseUnMed { get; set; }
}
