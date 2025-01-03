using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSap;

public partial class Ottp
{
    public short UserSign { get; set; }

    public int ObjectId { get; set; }

    public string? IsEnabled { get; set; }
}
