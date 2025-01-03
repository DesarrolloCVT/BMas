using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSap;

public partial class Odcr
{
    public string RuleCode { get; set; } = null!;

    public string? RuleDesc { get; set; }

    public string? PastRcp { get; set; }

    public string? AutoAtp { get; set; }

    public string? Slduncfm { get; set; }

    public string? AllowUncfm { get; set; }

    public string? CmltStrtg { get; set; }

    public string? DeliStrtg { get; set; }

    public int? MaxPrpsls { get; set; }

    public string? ValidFor { get; set; }

    public string? ValidFrom { get; set; }

    public string? ValidTo { get; set; }

    public string? FrozenFor { get; set; }

    public string? FrozenFrom { get; set; }

    public string? FrozenTo { get; set; }

    public string? Locked { get; set; }
}
