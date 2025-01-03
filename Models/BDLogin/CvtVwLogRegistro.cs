using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDLogin;

public partial class CvtVwLogRegistro
{
    public int LogId { get; set; }

    public string NombreSubMenu { get; set; } = null!;

    public string NombreMenu { get; set; } = null!;

    public string Tipo { get; set; } = null!;

    public string NombreUsuario { get; set; } = null!;

    public DateTime Fecha { get; set; }

    public int? Mes { get; set; }

    public int? Año { get; set; }
}
