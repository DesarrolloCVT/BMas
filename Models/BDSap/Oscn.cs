using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSap;

public partial class Oscn
{
    public string ItemCode { get; set; } = null!;

    public string CardCode { get; set; } = null!;

    public string Substitute { get; set; } = null!;

    public string? Transfered { get; set; }

    public string? DataSource { get; set; }

    public short? UserSign { get; set; }

    public short? UserSign2 { get; set; }

    public string? ShowScn { get; set; }

    public string? IsDefault { get; set; }

    public string? Descriptio { get; set; }

    public int? DataVers { get; set; }
}
