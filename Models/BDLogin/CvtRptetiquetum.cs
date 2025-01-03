using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDLogin;

public partial class CvtRptetiquetum
{
    public int PackageId { get; set; }

    public string PackageSscc { get; set; } = null!;

    public int ContImpresiones { get; set; }

    /// <summary>
    /// 1: Normal   2: Producción
    /// </summary>
    public int IdTipo { get; set; }

    public DateTime FechaImpresion { get; set; }
}
