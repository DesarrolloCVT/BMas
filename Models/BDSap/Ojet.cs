using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSap;

public partial class Ojet
{
    public string Jetype { get; set; } = null!;

    public string? Locked { get; set; }

    public string? DocTypDesc { get; set; }

    public string? ShortName { get; set; }

    public string? DataSource { get; set; }

    public short? UserSign { get; set; }
}
