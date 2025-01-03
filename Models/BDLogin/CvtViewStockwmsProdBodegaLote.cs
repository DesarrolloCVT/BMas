using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDLogin;

public partial class CvtViewStockwmsProdBodegaLote
{
    public string? Almacen { get; set; }

    public string? ArticleProviderCodClient { get; set; }

    public string? ArticleProviderDescription { get; set; }

    public DateOnly? Fproduccion { get; set; }

    public DateOnly? Fvencimiento { get; set; }

    public string? Lote { get; set; }

    public int Cantidad { get; set; }

    public string? SiteShortDescription { get; set; }

    public string? Sscc { get; set; }

    public string? LayoutDescription { get; set; }
}
