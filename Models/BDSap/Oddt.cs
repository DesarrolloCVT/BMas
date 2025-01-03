using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSap;

public partial class Oddt
{
    public int Numerator { get; set; }

    public string CardCode { get; set; } = null!;

    public string TrcCode { get; set; } = null!;

    public string? TrcName { get; set; }

    public DateTime? DateFrom { get; set; }

    public DateTime? DateTo { get; set; }

    public string? DataSource { get; set; }

    public short? UserSign { get; set; }

    public DateTime? LastUpdate { get; set; }

    public string WhshaamGrp { get; set; } = null!;

    public decimal? DdctPrcnt { get; set; }

    public decimal? MaxSum { get; set; }
}
