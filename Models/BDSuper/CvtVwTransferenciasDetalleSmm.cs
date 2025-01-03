using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSuper;

public partial class CvtVwTransferenciasDetalleSmm
{
    public int TransferId { get; set; }

    public int PackageId { get; set; }

    public string? LayoutDescription { get; set; }

    public string? SiteDescription { get; set; }

    public string ItemCode { get; set; } = null!;

    public string? ItemName { get; set; }

    public string? PackageSscc { get; set; }

    public string? PackageLot { get; set; }

    public int? Status { get; set; }

    public DateTime? Date { get; set; }

    public int? LayoutIdActual { get; set; }

    public decimal? PackageQuantity { get; set; }

    public int SiteId { get; set; }

    public DateTime? PackageProductionDate { get; set; }

    public short? PackageConfirm { get; set; }

    public string? Medida { get; set; }

    public int? BaseUnMed { get; set; }
}
