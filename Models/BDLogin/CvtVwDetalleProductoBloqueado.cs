using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDLogin;

public partial class CvtVwDetalleProductoBloqueado
{
    public int? IdProdBloqueado { get; set; }

    public int IdProdBloqDetalle { get; set; }

    public int? IdPackage { get; set; }

    public string? PackageSscc { get; set; }

    public string? ArticleProviderCodClient { get; set; }

    public string? ArticleProviderDescription { get; set; }

    public string? Bodega { get; set; }

    public string? Ubicacion { get; set; }

    public string? PackageLot { get; set; }

    public int PackageQuantity { get; set; }
}
