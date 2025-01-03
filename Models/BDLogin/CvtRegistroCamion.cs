using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDLogin;

public partial class CvtRegistroCamion
{
    public int IdRegistroCamion { get; set; }

    public int IdCamion { get; set; }

    public int IdChofer { get; set; }

    public int IdPeoneta { get; set; }

    public string Patente { get; set; } = null!;

    public string? PatenteRampla { get; set; }

    public string? Referencia { get; set; }

    public int? TipoDocumento { get; set; }

    public int? NumDocumento { get; set; }

    public DateTime? FechaIngreso { get; set; }

    public DateTime? FechaSalida { get; set; }
}
