using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSap;

public partial class Flcban
{
    public string Code { get; set; } = null!;

    public string Name { get; set; } = null!;

    public string? UTipo { get; set; }

    public string? UCurrency { get; set; }

    public decimal? URate { get; set; }

    public DateTime? UFecUltAct { get; set; }

    public decimal? UMaximo { get; set; }

    public decimal? UMonto { get; set; }

    public decimal? ULocal { get; set; }

    public string? UConcepto { get; set; }

    public string? UCuenta { get; set; }

    public string? UBankCode { get; set; }
}
