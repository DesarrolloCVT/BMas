using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDLogin;

public partial class CvtInventarioEstadoDet
{
    public int InventarioEstadoDetId { get; set; }

    public int InventarioEstadoId { get; set; }

    public string Bodega { get; set; } = null!;

    public int Wms { get; set; }

    public int Sap { get; set; }

    public int Inventariado { get; set; }
}
