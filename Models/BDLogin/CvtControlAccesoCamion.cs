using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDLogin;

public partial class CvtControlAccesoCamion
{
    public int IdRegistro { get; set; }

    public string Patente { get; set; } = null!;

    public string? PatenteRampla { get; set; }

    public int? ChoferId { get; set; }

    public int? Motivo { get; set; }

    public DateTime? FechaIngreso { get; set; }

    public DateTime? FechaSalida { get; set; }

    public int? TipoTransporte { get; set; }

    public int? TipoDocumento { get; set; }

    public int? NumDocumento { get; set; }

    public string? Referencia { get; set; }

    public string? Observaciones { get; set; }

    public int? CantidadPeonetas { get; set; }
}
