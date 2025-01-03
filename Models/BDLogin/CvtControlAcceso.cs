using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDLogin;

public partial class CvtControlAcceso
{
    public int AccesoCamionId { get; set; }

    public int? IdCamion { get; set; }

    public int? IdChofer { get; set; }

    public string? Patente { get; set; }

    public string? PatenteRampla { get; set; }

    public DateTime? FechaIngreso { get; set; }

    public DateTime? FechaSalida { get; set; }

    public int? TipoDocumento { get; set; }

    public string? Comentario { get; set; }

    public int? Motivo { get; set; }

    public bool? Propio { get; set; }

    public string? Chofer { get; set; }

    public bool? Devolucion { get; set; }

    public DateTime? FechaEntrega { get; set; }

    public int? Estado { get; set; }
}
