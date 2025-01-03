using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDLogin;

public partial class CvtVwTransferenciasDetalle
{
    public int TransferId { get; set; }

    public int PackageId { get; set; }

    public string? LayoutShortDescription { get; set; }

    public string? SiteShortDescription { get; set; }

    public string? ArticleProviderCodClient { get; set; }

    public string? ArticleProviderDescription { get; set; }

    public string? PackageSscc { get; set; }

    public string? PackageLot { get; set; }

    public int? Status { get; set; }

    public DateTime? Date { get; set; }

    public int? TaskId { get; set; }

    public int? LayoutIdActual { get; set; }

    public int SiteId { get; set; }

    public int? TaskQuantityToPick { get; set; }

    public int? TaskQuantityPicked { get; set; }

    public int PackageQuantity { get; set; }

    public DateTime PackageProductionDate { get; set; }
}
