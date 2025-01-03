using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDLogin;

public partial class CvtInfMantencionEncabezado
{
    public int IdMantInfEnc { get; set; }

    public DateTime FechaMantencion { get; set; }

    public string TipoMantencion { get; set; } = null!;

    public int IdUsuario { get; set; }

    public string? Falla { get; set; }

    public string? Causa { get; set; }

    public string? Solucion { get; set; }

    public string? Observacion { get; set; }

    public string CodActivo { get; set; } = null!;
}
