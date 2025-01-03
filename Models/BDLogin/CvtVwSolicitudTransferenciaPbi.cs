using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDLogin;

public partial class CvtVwSolicitudTransferenciaPbi
{
    public int Folio { get; set; }

    public string? BodegaOrigen { get; set; }

    public string? BodegaDestino { get; set; }

    public DateTime? FechaSolicitud { get; set; }

    public string NombreUsuario { get; set; } = null!;

    public string? Estado { get; set; }

    public int? NumeroOf { get; set; }
}
