using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSap;

public partial class Nnm2
{
    public string ObjectCode { get; set; } = null!;

    public short UserSign { get; set; }

    public int? Series { get; set; }

    public string DocSubType { get; set; } = null!;
}
