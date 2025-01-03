using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDLogin;

public partial class CvtVwTranferSaplote
{
    public int TransferId { get; set; }

    public string? PackageLot { get; set; }

    public int? Quantity { get; set; }

    public string? ArticleProviderCodClient { get; set; }

    public string? ArticleProviderDescription { get; set; }
}
