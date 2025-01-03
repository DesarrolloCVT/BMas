using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDLogin;

public partial class CvtControlEnvasadoPtUsoCintaImpresion
{
    public int IdControlEnvPt { get; set; }

    public int IdUsoCintaImp { get; set; }

    public int? Cantidad { get; set; }

    public string? Lote { get; set; }

    public int? IdUsuario { get; set; }

    public DateTime? FechaRegistro { get; set; }
}
