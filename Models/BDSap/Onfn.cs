using System;
using System.Collections.Generic;

namespace NuevoBMas.Models.BDSap;

public partial class Onfn
{
    public string ObjectCode { get; set; } = null!;

    public int? AutoKey { get; set; }

    public short? DfltSeq { get; set; }

    public short? UpdCounter { get; set; }

    public short? UserSign { get; set; }

    public string DocSubType { get; set; } = null!;
}
