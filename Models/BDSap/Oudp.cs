using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSap;

public partial class Oudp
{
    public short Code { get; set; }

    public string Name { get; set; } = null!;

    public string? Remarks { get; set; }

    public short? UserSign { get; set; }

    public string? Father { get; set; }
}
