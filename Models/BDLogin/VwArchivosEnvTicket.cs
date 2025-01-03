using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDLogin;

public partial class VwArchivosEnvTicket
{
    public string Operacion { get; set; } = null!;

    public string? Nombre { get; set; }

    public string? Extencion { get; set; }

    public string? Ruta { get; set; }

    public int? IdTicket { get; set; }
}
