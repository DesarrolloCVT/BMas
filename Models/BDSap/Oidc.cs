using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSap;

public partial class Oidc
{
    public string Code { get; set; } = null!;

    public string? Name { get; set; }

    public short? UserSign { get; set; }

    public string UExxIntegra { get; set; } = null!;

    public string? UX4rInterkey { get; set; }
}
