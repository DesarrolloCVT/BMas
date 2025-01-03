using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDLogin;

public partial class VwDevolucionDetailSyncFilm
{
    public int IdDevoFilm { get; set; }

    public string? SiteShortDescription { get; set; }

    public string? Item { get; set; }

    public string? CodProducto { get; set; }

    public string? DescripcionProducto { get; set; }

    public string? Proveedor { get; set; }

    public decimal? AvgPrice { get; set; }

    public decimal? Cantidad { get; set; }
}
