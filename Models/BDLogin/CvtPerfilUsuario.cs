using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDLogin;

public partial class CvtPerfilUsuario
{
    public int IdPerfil { get; set; }

    public string NombrePerfil { get; set; } = null!;

    public virtual ICollection<CvtPrivilegioPerfil> CvtPrivilegioPerfils { get; set; } = new List<CvtPrivilegioPerfil>();
}
