using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDLogin;

public partial class CvtVwFiltroTransferencium
{
    public int PackageId { get; set; }

    public int? LayoutId { get; set; }

    public int ArticleProviderId { get; set; }

    public string? ArticleProviderCodClient { get; set; }

    public string? ArticleProviderDescription { get; set; }

    public string? PackageSscc { get; set; }

    public int SiteId { get; set; }

    public string? LayoutShortDescription { get; set; }

    public string? SiteShortDescription { get; set; }

    public string? PackageLot { get; set; }

    public int PackageQuantity { get; set; }
}
