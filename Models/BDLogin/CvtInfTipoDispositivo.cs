using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDLogin;

public partial class CvtInfTipoDispositivo
{
    public int IdTipoDispositivo { get; set; }

    public string? Nombre { get; set; }

    public int? IdFiltro { get; set; }
}
