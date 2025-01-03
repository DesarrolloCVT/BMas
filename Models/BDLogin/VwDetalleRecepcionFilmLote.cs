using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDLogin;

public partial class VwDetalleRecepcionFilmLote
{
    public int FolioRecepFilm { get; set; }

    public string? SiteShortDescription { get; set; }

    public decimal? Cantidad { get; set; }

    public string? LoteInterno { get; set; }

    public string? Producto { get; set; }
}
