using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDLogin;

public partial class CvtFilmTransferencium
{
    public int IdTransferenciaFilm { get; set; }

    public int? BodOrigen { get; set; }

    public int? BodDestino { get; set; }

    public DateTime? FechaTransferencia { get; set; }

    public int? UsuarioEnvia { get; set; }

    public int? UsuarioRecep { get; set; }

    public DateTime? FechaConfirmacion { get; set; }

    public int? Estado { get; set; }

    public int? EntidadMot { get; set; }

    public int? NumeroOf { get; set; }

    public int? Nsolicitud { get; set; }

    public int? TipoDefecto { get; set; }
}
