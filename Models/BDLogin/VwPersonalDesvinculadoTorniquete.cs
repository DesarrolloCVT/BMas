using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDLogin;

public partial class VwPersonalDesvinculadoTorniquete
{
    public DateTime FechaDesvinculacion { get; set; }

    public string? Apellido { get; set; }

    public string? Nombre { get; set; }

    public string? Razon { get; set; }

    public string Run { get; set; } = null!;
}
