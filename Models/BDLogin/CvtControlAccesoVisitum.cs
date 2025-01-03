using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDLogin;

public partial class CvtControlAccesoVisitum
{
    public int VisitaId { get; set; }

    public DateTime FechaEntrada { get; set; }

    public DateTime? FechaSalida { get; set; }

    public string Run { get; set; } = null!;

    public string Nombre { get; set; } = null!;

    public int Area { get; set; }

    public string Empleado { get; set; } = null!;

    public int Motivo { get; set; }

    public int Epp { get; set; }

    public string? Patente { get; set; }

    public int? Ntarjeta { get; set; }

    public string? Observacion { get; set; }

    public string? Empresa { get; set; }
}
