using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSap;

public partial class Ocst
{
    public string Code { get; set; } = null!;

    public string Country { get; set; } = null!;

    public string? Name { get; set; }

    public short? UserSign { get; set; }

    public short? ECode { get; set; }

    public string? Gnrecode { get; set; }

    public string? Gstcode { get; set; }

    public string? GstisUt { get; set; }

    public short? GroupCode { get; set; }
}
