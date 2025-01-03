using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDLogin;

public partial class CvtPrivilegioPerfil
{
    public int IdPerfil { get; set; }

    public int IdSubMenu { get; set; }

    public int Permiso { get; set; }

    public virtual CvtPerfilUsuario IdPerfilNavigation { get; set; } = null!;

    public virtual CvtSubMenu IdSubMenuNavigation { get; set; } = null!;
}
