﻿using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDLogin;

public partial class CvtVwStockDisponibleBajadaPedido
{
    public string? Almacen { get; set; }

    public string? ArticleProviderCodClient { get; set; }

    public string? ArticleProviderDescription { get; set; }

    public DateOnly? Fproduccion { get; set; }

    public DateOnly? Fvencimiento { get; set; }

    public string? Lote { get; set; }

    public int? Cantidad { get; set; }

    public string? SiteShortDescription { get; set; }

    public string? EstadoLote { get; set; }

    public string? Ubicacion { get; set; }

    public string? Sscc { get; set; }

    public int? SiteId { get; set; }
}