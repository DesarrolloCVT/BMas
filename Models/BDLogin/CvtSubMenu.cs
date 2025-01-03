using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDLogin;

public partial class CvtSubMenu
{
    public int IdSubMenu { get; set; }

    public int IdMenu { get; set; }

    public string NombreSubMenu { get; set; } = null!;

    public string UrlSubMenu { get; set; } = null!;

    public string? Tooltip { get; set; }

    public virtual ICollection<CvtPrivilegioPerfil> CvtPrivilegioPerfils { get; set; } = new List<CvtPrivilegioPerfil>();
}
