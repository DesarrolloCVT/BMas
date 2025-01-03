using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDLogin;

public partial class CvtViewTransformacionDetalleEntradaSap
{
    public int TransformacionId { get; set; }

    public string? ArticleProviderCodClient { get; set; }

    public string? ArticleProviderDescription { get; set; }

    public int? ArticleProviderDestinyId { get; set; }

    public int? Quantity { get; set; }

    public string? SiteShortDescription { get; set; }

    public int ArticleProviderId { get; set; }

    public string? Origen { get; set; }

    public int OrigenCantidad { get; set; }

    public string? PackageSscc { get; set; }
}
