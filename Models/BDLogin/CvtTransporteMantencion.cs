using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDLogin;

public partial class CvtTransporteMantencion
{
    public int IdMantencionTransporte { get; set; }

    public string? Patente { get; set; }

    public string? TipoMantencion { get; set; }

    public DateTime? FechaMantencion { get; set; }

    public int? Odometro { get; set; }

    public string? Descripcion { get; set; }

    public string? NombreChofer { get; set; }
}
