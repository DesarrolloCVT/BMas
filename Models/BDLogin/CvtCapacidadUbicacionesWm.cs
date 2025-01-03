using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDLogin;

public partial class CvtCapacidadUbicacionesWm
{
    public int SiteId { get; set; }

    public int LayoutId { get; set; }

    public int Pasillo { get; set; }

    public string BodegaSap { get; set; } = null!;

    public int CantPallets { get; set; }

    public int Estado { get; set; }
}
