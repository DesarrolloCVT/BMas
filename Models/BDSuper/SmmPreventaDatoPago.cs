using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSuper;

public partial class SmmPreventaDatoPago
{
    public int PreventaId { get; set; }

    public int IdTipoPago { get; set; }

    public string? TipoPago { get; set; }

    public int? Monto { get; set; }

    public int? NBoucher { get; set; }

    public int? Cuotas { get; set; }

    public string? Ntarjeta { get; set; }

    public string? TipoDocumento { get; set; }

    public int? Ncheque { get; set; }

    public DateTime? FechaDocumento { get; set; }
}
