using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDLogin;

public partial class CvtVwTransferenciaFilmPbi
{
    public int Folio { get; set; }

    public string? BodOrigen { get; set; }

    public string? BodDestino { get; set; }

    public int? Nsolicitud { get; set; }

    public DateTime? FechaTransferencia { get; set; }

    public string UsuarioEnvia { get; set; } = null!;

    public string? Estado { get; set; }

    public string? EntidadMot { get; set; }

    public int? TipoDefecto { get; set; }

    public int? Cantidad { get; set; }

    public int? NumeroOf { get; set; }

    public string UsuarioRecep { get; set; } = null!;

    public DateTime? FechaConfirmacion { get; set; }

    public int? Horas { get; set; }

    public int? Minutos { get; set; }
}
