using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDLogin;

public partial class CvtTicketsRespuestum
{
    public int IdRespuestaTicket { get; set; }

    public int? IdTicket { get; set; }

    public string? Respuesta { get; set; }

    public DateTime? FechaRespuesta { get; set; }

    public int? IdUsuario { get; set; }

    public int? RespuestaCierre { get; set; }
}
