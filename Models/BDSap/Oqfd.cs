using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSap;

public partial class Oqfd
{
    public int IntrnalKey { get; set; }

    public string QryCode { get; set; } = null!;

    public int CategoryId { get; set; }

    public string? BaseCode { get; set; }
}
