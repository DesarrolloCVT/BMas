using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSap;

public partial class Nfn2
{
    public string ObjectCode { get; set; } = null!;

    public short UserSign { get; set; }

    public short SeqCode { get; set; }

    public string DocSubType { get; set; } = null!;
}
