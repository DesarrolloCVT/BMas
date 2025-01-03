using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDLogin;

public partial class CvtArmadoCaja
{
    public int ArmadoId { get; set; }

    public DateTime Fecha { get; set; }

    public string? NumeroTarja { get; set; }

    public int CantCajas { get; set; }

    public int Turno { get; set; }

    public int ArmadorId { get; set; }
}
