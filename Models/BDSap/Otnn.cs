using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSap;

public partial class Otnn
{
    public int FormCode { get; set; }

    public string Form1099 { get; set; } = null!;

    public short? UserSign { get; set; }

    public string? Locked { get; set; }
}
