using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDLogin;

public partial class VwDetalleRecepcionFilm
{
    public int FolioRecepFilm { get; set; }

    public string? SiteShortDescription { get; set; }

    public decimal? Cantidad { get; set; }

    public int? NumeroDocSap { get; set; }

    public int? NumeroDoc { get; set; }

    public DateTime? FechaRecep { get; set; }

    public string? Producto { get; set; }

    public string? Proveedor { get; set; }

    public string? Comentario { get; set; }
}
