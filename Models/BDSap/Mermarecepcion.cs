using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSap;

public partial class Mermarecepcion
{
    public string Code { get; set; } = null!;

    public string Name { get; set; } = null!;

    public int? UDocEntryRec { get; set; }

    public int? UDocNumRec { get; set; }

    public int? UBaseNum { get; set; }

    public short? ULineNumRec { get; set; }

    public string? UItemCode { get; set; }

    public int? UNumGuiaDesp { get; set; }

    public int? UReceptionId { get; set; }

    public string? UIndReclamoSeguro { get; set; }

    public string? UTipoMerma { get; set; }

    public short? UCantMerma { get; set; }

    public string? UManifiesto { get; set; }

    public string? UComentario { get; set; }

    public DateTime? UFechaReclamo { get; set; }

    public string? UNumPoliza { get; set; }

    public int? UCantReclamo { get; set; }

    public decimal? UMontoSiniestro { get; set; }

    public short? UPorcDeducible { get; set; }

    public decimal? UMontoDeducible { get; set; }

    public decimal? UMontoPagoSin { get; set; }

    public DateTime? UFechaPagoSin { get; set; }

    public string? UComenSiniestro { get; set; }
}
