using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSap;

public partial class Odgl
{
    public string GroupCode { get; set; } = null!;

    public string? GroupName { get; set; }

    public short? UserSign { get; set; }
}
