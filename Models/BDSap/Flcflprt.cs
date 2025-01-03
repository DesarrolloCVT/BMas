using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSap;

public partial class Flcflprt
{
    public string Code { get; set; } = null!;

    public string Name { get; set; } = null!;

    public int? UNro { get; set; }

    public string? UTipo { get; set; }

    public string? UConcepto { get; set; }

    public string? UDocum { get; set; }

    public DateTime? UFecvcto { get; set; }

    public int? UEdad { get; set; }

    public string? UCurrency { get; set; }

    public decimal? UMonto { get; set; }

    public decimal? UPesos { get; set; }

    public string? UCardCode { get; set; }

    public string? UCardName { get; set; }

    public DateTime? UTaxdate { get; set; }

    public string? UTipoDoc { get; set; }

    public string? UFolio { get; set; }

    public string? UOrigen { get; set; }

    public int? UObjtype { get; set; }

    public string? USubType { get; set; }

    public int? UDocentry { get; set; }
}
