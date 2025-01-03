using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDLogin;

public partial class CvtFilmSolicitudTransferenciaDetalle
{
    public int IdDetSolicitud { get; set; }

    public int? IdSolicitud { get; set; }

    public string? Producto { get; set; }

    public int? CantBobinas { get; set; }

    public decimal? KilosAproximados { get; set; }

    public string? Comentarios { get; set; }
}
