using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDLogin;

public partial class CvtInfEntregaPeriferico
{
    public int IdEntPeriferico { get; set; }

    public DateTime? FechaEntrega { get; set; }

    public string? RunUser { get; set; }
}
