using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSap;

public partial class Flcopn
{
    public string Code { get; set; } = null!;

    public string Name { get; set; } = null!;

    public string? UTipo { get; set; }

    public int? UCorrel { get; set; }

    public string? UDocum { get; set; }

    public DateTime? UFecdoc { get; set; }

    public DateTime? UFecvcto { get; set; }

    public string? UReferencia { get; set; }

    public string? UEstado { get; set; }

    public string? UConcepto { get; set; }

    public decimal? UMontoDoc { get; set; }

    public string? UCurrency { get; set; }

    public decimal? UCurrRate { get; set; }

    public decimal? UMontoLoc { get; set; }

    public string? UComments { get; set; }

    public string? UAttach1 { get; set; }

    public string? UBankCode { get; set; }

    public int UBplid { get; set; }

    public string? UProject { get; set; }
}
