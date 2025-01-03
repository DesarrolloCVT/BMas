using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDLogin;

public partial class CvtPermisosSistInterno
{
    public int IdSistema { get; set; }

    public int IdUsuario { get; set; }

    public string Funcion { get; set; } = null!;

    public short TipoPermiso { get; set; }
}
