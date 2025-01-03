using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSap;

public partial class Ocrg
{
    public short GroupCode { get; set; }

    public string GroupName { get; set; } = null!;

    public string? GroupType { get; set; }

    public string? Locked { get; set; }

    public string? DataSource { get; set; }

    public short? UserSign { get; set; }

    public short? PriceList { get; set; }

    public string? DiscRel { get; set; }

    public string? EffecPrice { get; set; }

    public string UExxIntegra { get; set; } = null!;

    public string? UX4rInterkey { get; set; }

    public string? UX4rCodproy { get; set; }

    public string? UX4rCoddim1 { get; set; }

    public string? UX4rCoddim2 { get; set; }

    public string? UX4rCoddim3 { get; set; }

    public string? UX4rCoddim4 { get; set; }

    public string? UX4rCoddim5 { get; set; }
}
