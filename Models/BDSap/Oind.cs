using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSap;

public partial class Oind
{
    public string Code { get; set; } = null!;

    public string? Name { get; set; }

    public short? UserSign { get; set; }
}
