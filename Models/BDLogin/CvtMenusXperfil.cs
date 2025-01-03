using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDLogin;

public partial class CvtMenusXperfil
{
    public int IdPerfil { get; set; }

    public string NombrePerfil { get; set; } = null!;

    public int IdMenu { get; set; }

    public string NombreMenu { get; set; } = null!;

    public int IdSubMenu { get; set; }

    public string NombreSubMenu { get; set; } = null!;

    public string UrlSubMenu { get; set; } = null!;
}
