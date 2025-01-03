using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDLogin;

public partial class CvtTransformacionDetalle
{
    public int TransformacionDetId { get; set; }

    public int TransformacionId { get; set; }

    public int PackageId { get; set; }

    public int PackageQuantity { get; set; }

    public int ArticleProviderId { get; set; }

    public int? PackageDestinyId { get; set; }

    public int? PackageDestinyQuantity { get; set; }

    public int? ArticleProviderDestinyId { get; set; }

    public int? LayoutId { get; set; }
}
