using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSuper;

public partial class SmmSolicitudTransferencium
{
    public int IdSolicitud { get; set; }

    public int? BodegaOrigen { get; set; }

    public int? BodegaDestino { get; set; }

    public DateTime? FechaSolicitud { get; set; }

    public int? IdUsuario { get; set; }

    public int? Estado { get; set; }

    public string? Comentarios { get; set; }
}
