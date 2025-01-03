using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDLogin;

public partial class CvtAsignacionFoliosCheque
{
    public int NInternoSap { get; set; }

    public int FolioAsignado { get; set; }

    public int FolioCorrecto { get; set; }

    public string? Proveedor { get; set; }
}
