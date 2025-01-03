using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDLogin;

public partial class CvtTrazabilidadSecuenciaEmisionRpt
{
    public string NombreReporte { get; set; } = null!;

    public short? CantParametros { get; set; }

    public string? ValorParametro { get; set; }

    public string NombreArchivo { get; set; } = null!;

    public string? CampoKey { get; set; }

    public short? CampoOrden { get; set; }
}
