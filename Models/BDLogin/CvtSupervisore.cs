using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDLogin;

public partial class CvtSupervisore
{
    public int IdRegistroSupervision { get; set; }

    public int? IdSuperVisor { get; set; }

    public string? NombreSupervisor { get; set; }

    public int? IdVendedor { get; set; }

    public string? NombreVendedor { get; set; }

    public string? Zona { get; set; }
}
