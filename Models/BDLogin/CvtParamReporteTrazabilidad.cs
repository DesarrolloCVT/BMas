using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDLogin;

public partial class CvtParamReporteTrazabilidad
{
    public int IdReporte { get; set; }

    public int DetIdReporte { get; set; }

    public string NombreParam { get; set; } = null!;

    public string TipoDato { get; set; } = null!;

    public short OrdenParam { get; set; }
}
