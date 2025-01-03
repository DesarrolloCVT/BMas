using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDLogin;

public partial class CvtReporteTrazabilidad
{
    public int IdReporte { get; set; }

    public string NombreReporte { get; set; } = null!;

    public string Descripción { get; set; } = null!;

    public short CantParametros { get; set; }

    public string NombreArchivo { get; set; } = null!;
}
