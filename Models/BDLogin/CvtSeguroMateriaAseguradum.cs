using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDLogin;

public partial class CvtSeguroMateriaAseguradum
{
    public int IdMateriaAsegurada { get; set; }

    public string? Descripcion { get; set; }

    public int? IdTipoSeguro { get; set; }
}
