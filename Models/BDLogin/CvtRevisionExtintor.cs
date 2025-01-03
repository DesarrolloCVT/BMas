using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDLogin;

public partial class CvtRevisionExtintor
{
    public int IdRevisionExtintor { get; set; }

    public int? IdUsuario { get; set; }

    public DateTime? FechaInspeccion { get; set; }

    public int? Nextintor { get; set; }

    public DateTime? VigenciaRecarga { get; set; }

    public string? Ubicacion { get; set; }

    public int? PesoExtintor { get; set; }

    public string? TipoAgente { get; set; }
}
