using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDLogin;

public partial class CvtFilmSolicitudTransferencium
{
    public int IdSolicitud { get; set; }

    public int? BodegaOrigen { get; set; }

    public int? BodegaDestino { get; set; }

    public DateTime? FechaSolicitud { get; set; }

    public int? IdUsuario { get; set; }

    public int? Estado { get; set; }

    public int? NumeroOf { get; set; }
}
