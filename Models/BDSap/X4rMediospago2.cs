using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSap;

public partial class X4rMediospago2
{
    public string Code { get; set; } = null!;

    public int LineId { get; set; }

    public string? Object { get; set; }

    public int? LogInst { get; set; }

    public string? UX4rCodmoneda { get; set; }

    public DateTime? UX4rFechadesde { get; set; }

    public DateTime? UX4rFechahasta { get; set; }

    public string? UX4rTipodescto { get; set; }

    public decimal? UX4rDescuento { get; set; }

    public decimal? UX4rValorminimo { get; set; }

    public decimal? UX4rValormaximo { get; set; }

    public string? UX4rAplicadescto { get; set; }
}
