using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDLogin;

public partial class CvtVwPackageArticle
{
    public int TransferId { get; set; }

    public int PackageId { get; set; }

    public string? PackageSscc { get; set; }

    public string? ArticleProviderCodClient { get; set; }

    public string? ArticleProviderDescription { get; set; }
}
