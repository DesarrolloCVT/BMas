using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDLogin;

public partial class CvtRegistroSaturacionPatrone
{
    public int IdSaturacionPatrones { get; set; }

    public int IdUsuario { get; set; }

    public string ItemCode { get; set; } = null!;

    public DateTime FechaRegistro { get; set; }

    public TimeOnly HoraRegistro { get; set; }

    public int PasadasSeguidas { get; set; }

    public short Fe25mm { get; set; }

    public short Nofe30mm { get; set; }

    public short Acero25mm { get; set; }

    public short EnciendeBaliza { get; set; }

    public short SuenaBaliza { get; set; }

    public short BrazoRechazo { get; set; }

    public DateTime? FechaIngresoRegistro { get; set; }

    public string? Observaciones { get; set; }
}
