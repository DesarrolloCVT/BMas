using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDLogin;

public partial class CvtTicketsArchivoAdjunto
{
    public int IdAdjuntoTicket { get; set; }

    public int? IdTicket { get; set; }

    public string? Ruta { get; set; }

    public string? Nombre { get; set; }

    public string? Extencion { get; set; }
}
