using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDLogin;

public partial class VwOperadorVsUsuario
{
    public int IdPersonal { get; set; }

    public string Nombre { get; set; } = null!;

    public int IdUsuario { get; set; }
}
