using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSuper;

public partial class VwListadoProductosSolicitud
{
    public int? IdSolicitud { get; set; }

    public string? ItemCode { get; set; }

    public string? ItemName { get; set; }

    public decimal? Cantidad { get; set; }
}
