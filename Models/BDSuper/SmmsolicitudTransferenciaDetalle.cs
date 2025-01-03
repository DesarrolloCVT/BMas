using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSuper;

public partial class SmmsolicitudTransferenciaDetalle
{
    public int IdDetSolicitud { get; set; }

    public int? IdSolicitud { get; set; }

    public string? ItemCode { get; set; }

    public decimal? Cantidad { get; set; }
}
