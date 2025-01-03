using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDLogin;

public partial class CvtTicketAdjuntoRespuestum
{
    public int IdAdjTicketResp { get; set; }

    public int? IdTicket { get; set; }

    public string? Ruta { get; set; }

    public string? Nombre { get; set; }

    public string? Extencion { get; set; }

    public int? IdRespTiquet { get; set; }
}
