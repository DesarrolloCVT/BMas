using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDLogin;

public partial class CvtVwRecepcionFilmPbi
{
    public int Folio { get; set; }

    public string? BodRecepcion { get; set; }

    public string Proveedor { get; set; } = null!;

    public DateTime? FechaRecepcion { get; set; }

    public string NombreUsuario { get; set; } = null!;

    public string? TipoDocumento { get; set; }

    public int? NDocumento { get; set; }

    public string? DocumentoSap { get; set; }

    public int? NumDocSap { get; set; }

    public string? Comentario { get; set; }

    public string? Estado { get; set; }
}
