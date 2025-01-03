using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDLogin;

public partial class CvtFilmRecepcion
{
    public int FolioRecepFilm { get; set; }

    public int? BodegaRecep { get; set; }

    public string? Proveedor { get; set; }

    public DateTime? FechaRecep { get; set; }

    public int? UsuarioRecep { get; set; }

    public string? TipoDoc { get; set; }

    public int? NumeroDoc { get; set; }

    public string? DocumentoSap { get; set; }

    public int? NumeroDocSap { get; set; }

    public int? Estado { get; set; }

    public string? Comentario { get; set; }
}
