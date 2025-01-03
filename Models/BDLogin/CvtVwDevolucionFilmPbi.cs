using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDLogin;

public partial class CvtVwDevolucionFilmPbi
{
    public int Folio { get; set; }

    public string? Bodega { get; set; }

    public DateTime? FechaInicio { get; set; }

    public DateTime? FechaTermino { get; set; }

    public string? Motivo { get; set; }

    public string? Estado { get; set; }

    public string NombreUsuario { get; set; } = null!;

    public string? Proveedor { get; set; }

    public string? Comentarios { get; set; }
}
