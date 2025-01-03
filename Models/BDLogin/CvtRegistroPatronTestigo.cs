using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDLogin;

public partial class CvtRegistroPatronTestigo
{
    public int IdPatronesTestigo { get; set; }

    public DateTime FechaRegistro { get; set; }

    public TimeOnly Hora { get; set; }

    public string ItemCode { get; set; } = null!;

    public string Patron { get; set; } = null!;

    public short PatronDetectado { get; set; }

    public short EnciendeBaliza { get; set; }

    public short SuenaBaliza { get; set; }

    public short BrazodeRechazo { get; set; }

    public int IdUsuario { get; set; }

    public DateTime? FechaIngresoRegistro { get; set; }

    public string? Observacion { get; set; }
}
