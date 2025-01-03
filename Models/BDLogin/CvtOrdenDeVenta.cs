using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDLogin;

public partial class CvtOrdenDeVenta
{
    public int IdOrdenVentas { get; set; }

    public string? Cliente { get; set; }

    public DateTime? FechaEntrega { get; set; }

    public string? DirDespacho { get; set; }

    public string? DirFacturacion { get; set; }
}
