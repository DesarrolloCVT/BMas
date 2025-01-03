using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDLogin;

public partial class VwUsuariosXamarin
{
    public string UsuarioSistema { get; set; } = null!;

    public string NombreUsuario { get; set; } = null!;

    public int? IdPerfilMovile { get; set; }

    public int IdUsuario { get; set; }
}
