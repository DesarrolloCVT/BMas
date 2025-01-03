using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSap;

public partial class Ocnt
{
    public int AbsId { get; set; }

    public string Code { get; set; } = null!;

    public string Country { get; set; } = null!;

    public string State { get; set; } = null!;

    public string? Name { get; set; }

    public string? TaxZone { get; set; }

    public string? IbgeCode { get; set; }

    public string? GiaCode { get; set; }
}
