using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSap;

public partial class Ann3
{
    public string ObjectCode { get; set; } = null!;

    public int Series { get; set; }

    public string DocSubType { get; set; } = null!;

    public int LogInstanc { get; set; }
}
